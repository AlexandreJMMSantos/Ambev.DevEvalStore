using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Products.DeleteProduct;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.DeleteProduct;

/// <summary>
/// Profile for mapping between Application and API DeleteProduct responses
/// </summary>
public class DeleteProductProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for DeleteProduct feature
    /// </summary>
    public DeleteProductProfile()
    {
        CreateMap<DeleteProductRequest, DeleteProductCommand>();
        CreateMap<DeleteProductResponse, DeleteProductResponse>();
    }
}
