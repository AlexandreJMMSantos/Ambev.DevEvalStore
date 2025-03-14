using Ambev.DeveloperEvaluation.Domain.Entities;
using Bogus;

namespace Ambev.DeveloperEvaluation.Unit.Domain.Entities.TestData;

/// <summary>
/// Provides methods for generating test data using the Bogus library.
/// This class centralizes all test data generation to ensure consistency
/// across test cases and provide both valid and invalid data scenarios.
/// </summary>
public static class SaleTestData
{
    /// <summary>
    /// Configures the Faker to generate valid Sale entities.
    /// The generated sales will have valid:
    /// - SaleNumber (random identifier)
    /// - SaleDate (recent date)
    /// - ChartId (random Guid)
    /// - UserId (random Guid)
    /// - ProductId (random Guid)
    /// - Quantity (positive integer)
    /// - UnitPrice (positive decimal)
    /// - Discount (zero or positive decimal)
    /// - IsCancelled (random boolean)
    /// </summary>
    private static readonly Faker<Sale> SaleFaker = new Faker<Sale>()
        .RuleFor(s => s.SaleNumber, f => f.Random.AlphaNumeric(10).ToUpper())
        .RuleFor(s => s.SaleDate, f => f.Date.Recent())
        .RuleFor(s => s.ChartId, f => f.Random.Guid())
        .RuleFor(s => s.UserId, f => f.Random.Guid())
        .RuleFor(s => s.ProductId, f => f.Random.Guid())
        .RuleFor(s => s.Quantity, f => f.Random.Int(1, 100))
        .RuleFor(s => s.UnitPrice, f => f.Random.Decimal(1, 1000))
        .RuleFor(s => s.Discount, f => f.Random.Decimal(0, 100))
        .RuleFor(s => s.IsCancelled, f => f.Random.Bool());

    /// <summary>
    /// Generates a valid Sale entity with randomized data.
    /// The generated sale will have all properties populated with valid values
    /// that meet the system's validation requirements.
    /// </summary>
    /// <returns>A valid Sale entity with randomly generated data.</returns>
    public static Sale GenerateValidSale()
    {
        return SaleFaker.Generate();
    }

    /// <summary>
    /// Generates an invalid Sale entity for testing negative scenarios.
    /// The generated sale will have:
    /// - Quantity = 0 (invalid)
    /// - UnitPrice = 0 (invalid)
    /// - Negative discount (invalid)
    /// </summary>
    /// <returns>An invalid Sale entity.</returns>
    public static Sale GenerateInvalidSale()
    {
        return new Sale
        {
            SaleNumber = "",
            SaleDate = DateTime.MinValue,
            ChartId = Guid.Empty,
            UserId = Guid.Empty,
            ProductId = Guid.Empty,
            Quantity = 0,
            UnitPrice = 0,
            Discount = -10,
            IsCancelled = false
        };
    }
}
