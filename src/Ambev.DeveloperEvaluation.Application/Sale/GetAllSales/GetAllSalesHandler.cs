using MediatR;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Application.Sales.GetSale;
using Ambev.DeveloperEvaluation.Application.Sale.GetAllSales;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetAllSales;

/// <summary>
/// Handler for processing GetAllSalesCommand requests
/// </summary>
public class GetAllSalesHandler : IRequestHandler<GetAllSalesCommand, List<GetSaleResult>>
{
    private readonly ISaleRepository _saleRepository;

    public GetAllSalesHandler(ISaleRepository saleRepository)
    {
        _saleRepository = saleRepository;
    }

    public async Task<List<GetSaleResult>> Handle(GetAllSalesCommand request, CancellationToken cancellationToken)
    {
        var sales = await _saleRepository.GetAllAsync(cancellationToken);
        return sales.Select(sale => new GetSaleResult
        {
            Id = sale.Id,
            SaleNumber = sale.SaleNumber,
            SaleDate = sale.SaleDate,
            ChartId = sale.ChartId,
            UserId = sale.UserId,
            ProductId = sale.ProductId,
            Quantity = sale.Quantity,
            UnitPrice = sale.UnitPrice,
            Discount = sale.Discount,
            TotalAmount = sale.TotalAmount,
            IsCancelled = sale.IsCancelled
        }).ToList();
    }
}
