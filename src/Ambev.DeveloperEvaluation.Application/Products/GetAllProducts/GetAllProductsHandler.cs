using MediatR;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Application.Products.GetProduct;

namespace Ambev.DeveloperEvaluation.Application.Products.GetAllProducts;

/// <summary>
/// Handler for processing GetAllProductsCommand requests
/// </summary>
public class GetAllProductsHandler : IRequestHandler<GetAllProductsCommand, List<GetProductResult>>
{
    private readonly IProductRepository _productRepository;

    public GetAllProductsHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<List<GetProductResult>> Handle(GetAllProductsCommand request, CancellationToken cancellationToken)
    {
        var products = await _productRepository.GetAllAsync(cancellationToken);

        return products.Select(product => new GetProductResult
        {
            Id = product.Id,
            Title = product.Title,
            Price = product.Price,
            Description = product.Description,
            Category = product.Category,
            Rating = product.Rating != null
            ? new ProductRating { Rate = product.Rating.Rate, Count = product.Rating.Count }
            : new ProductRating()
        }).ToList();
    }



}
