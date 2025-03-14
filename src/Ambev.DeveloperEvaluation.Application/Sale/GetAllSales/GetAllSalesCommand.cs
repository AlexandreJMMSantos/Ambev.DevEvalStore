using Ambev.DeveloperEvaluation.Application.Sales.GetSale;
using MediatR;
using System.Collections.Generic;

namespace Ambev.DeveloperEvaluation.Application.Sale.GetAllSales;

/// <summary>
/// Command for retrieving all sales
/// </summary>
public class GetAllSalesCommand : IRequest<List<GetSaleResult>>
{
}