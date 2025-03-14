using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Sales.GetSale;
using Ambev.DeveloperEvaluation.Application.Sale.GetAllSales;
using Ambev.DeveloperEvaluation.Application.Products.GetAllProducts;
using Ambev.DeveloperEvaluation.Application.Products.GetProduct;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetAllSales;

/// <summary>
/// Profile for mapping between Sale entity and GetAllSalesResponse
/// </summary>
public class GetAllSalesProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for GetAllSales operation
    /// </summary>
    public GetAllSalesProfile()
    {
        CreateMap<GetAllSalesCommand, List<Domain.Entities.Sale>>();
        CreateMap<Domain.Entities.Sale, GetSaleResult>();
    }
}