using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Products.GetAllProducts;
using Ambev.DeveloperEvaluation.Application.Products.GetProduct;
using Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProduct;
using Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetAllProducts;

/// <summary>
/// Profile for mapping GetAllProducts feature requests to commands
/// </summary>
public class GetAllProductsProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for GetAllProducts feature
    /// </summary>
    public GetAllProductsProfile()
    {
        CreateMap<GetAllProductsRequest, GetAllProductsCommand>();

        CreateMap<GetProductResult, GetProductResponse>()
            .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => new Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProduct.ProductRating
            {
                Rate = src.Rating.Rate,
                Count = src.Rating.Count
            }));

        CreateMap<Ambev.DeveloperEvaluation.Application.Products.GetProduct.ProductRating,
                  Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProduct.ProductRating>();
    }
}
