using Ambev.DeveloperEvaluation.Application.Products.GetProduct;
using MediatR;
using System.Collections.Generic;

namespace Ambev.DeveloperEvaluation.Application.Products.GetAllProducts;

/// <summary>
/// Command for retrieving all products
/// </summary>
public class GetAllProductsCommand : IRequest<List<GetProductResult>>
{
}