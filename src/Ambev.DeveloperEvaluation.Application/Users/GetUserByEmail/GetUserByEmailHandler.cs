using AutoMapper;
using MediatR;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Repositories;

namespace Ambev.DeveloperEvaluation.Application.Users.GetUserByEmail;

/// <summary>
/// Handler for processing GetUserByEmailCommand requests
/// </summary>
public class GetUserByEmailHandler : IRequestHandler<GetUserByEmailCommand, GetUserByEmailResult>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of GetUserByEmailHandler
    /// </summary>
    /// <param name="userRepository">The user repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    public GetUserByEmailHandler(
        IUserRepository userRepository,
        IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the GetUserByEmailCommand request
    /// </summary>
    /// <param name="request">The GetUserByEmail command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The user details if found</returns>
    public async Task<GetUserByEmailResult> Handle(GetUserByEmailCommand request, CancellationToken cancellationToken)
    {
        var validator = new GetUserByEmailValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        var user = await _userRepository.GetByEmailAsync(request.Email, cancellationToken);
        if (user == null)
            throw new KeyNotFoundException($"User with email {request.Email} not found");

        return _mapper.Map<GetUserByEmailResult>(user);
    }
}
