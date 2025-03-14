using Ambev.DeveloperEvaluation.Domain.Entities;
using Bogus;

namespace Ambev.DeveloperEvaluation.Unit.Domain.Specifications.TestData;

/// <summary>
/// Provides methods for generating test data for CompletedSalesSpecification tests.
/// This class centralizes all test data generation to ensure consistency across test cases.
/// </summary>
public static class CompletedSalesSpecificationTestData
{
    /// <summary>
    /// Configures the Faker to generate valid Sale entities.
    /// The generated sales will have:
    /// - SaleNumber (random string)
    /// - SaleDate (recent past date)
    /// - UserId (random Guid)
    /// - ProductId (random Guid)
    /// - Quantity (random positive integer)
    /// - UnitPrice (random decimal)
    /// - Discount (random decimal)
    /// - IsCancelled (controlled per test case)
    /// </summary>
    private static readonly Faker<Sale> saleFaker = new Faker<Sale>()
        .CustomInstantiator(f => new Sale
        {
            SaleNumber = f.Random.AlphaNumeric(10),
            SaleDate = f.Date.Past(1),
            UserId = Guid.NewGuid(),
            ProductId = Guid.NewGuid(),
            Quantity = f.Random.Int(1, 10),
            UnitPrice = f.Random.Decimal(10, 500),
            Discount = f.Random.Decimal(0, 50),
            IsCancelled = f.Random.Bool()
        });

    /// <summary>
    /// Generates a valid Sale entity with the specified cancellation status.
    /// </summary>
    /// <param name="isCancelled">Determines whether the sale should be marked as cancelled.</param>
    /// <returns>A valid Sale entity with the specified status.</returns>
    public static Sale GenerateSale(bool isCancelled)
    {
        var sale = saleFaker.Generate();
        sale.IsCancelled = isCancelled;
        return sale;
    }
}
