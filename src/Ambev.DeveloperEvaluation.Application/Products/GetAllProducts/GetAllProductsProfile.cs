using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Application.Products.GetProduct;

namespace Ambev.DeveloperEvaluation.Application.Products.GetAllProducts;

/// <summary>
/// Profile for mapping between Product entity and GetAllProductsResponse
/// </summary>
public class GetAllProductsProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for GetAllProducts operation
    /// </summary>
    public GetAllProductsProfile()
    {
        CreateMap<GetAllProductsCommand, List<Product>>();
        CreateMap<Product, GetProductResult>();
    }
}