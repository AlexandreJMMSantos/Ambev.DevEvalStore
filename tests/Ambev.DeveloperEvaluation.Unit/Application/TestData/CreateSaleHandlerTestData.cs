using Ambev.DeveloperEvaluation.Application.Sales.CreateSale;
using Bogus;

namespace Ambev.DeveloperEvaluation.Unit.Domain;

/// <summary>
/// Provides methods for generating test data using the Bogus library.
/// This class centralizes all test data generation to ensure consistency
/// across test cases and provide both valid and invalid data scenarios.
/// </summary>
public static class CreateSaleHandlerTestData
{
    /// <summary>
    /// Configures the Faker to generate valid Sale entities.
    /// The generated sales will have valid:
    /// - SaleNumber (random unique identifier)
    /// - SaleDate (current or past date)
    /// - UserId (valid GUID)
    /// - ProductId (valid GUID)
    /// - Quantity (positive integer)
    /// - UnitPrice (positive decimal value)
    /// - Discount (zero or positive decimal value)
    /// </summary>
    private static readonly Faker<CreateSaleCommand> createSaleHandlerFaker = new Faker<CreateSaleCommand>()
        .RuleFor(s => s.SaleNumber, f => f.Random.Guid().ToString())
        .RuleFor(s => s.SaleDate, f => f.Date.Past(1))
        .RuleFor(s => s.ChartId, f => Guid.NewGuid())
        .RuleFor(s => s.UserId, f => Guid.NewGuid())
        .RuleFor(s => s.ProductId, f => Guid.NewGuid())
        .RuleFor(s => s.Quantity, f => f.Random.Int(1, 100))
        .RuleFor(s => s.UnitPrice, f => f.Random.Decimal(1, 1000))
        .RuleFor(s => s.Discount, f => f.Random.Decimal(0, 100));

    /// <summary>
    /// Generates a valid Sale entity with randomized data.
    /// The generated sale will have all properties populated with valid values
    /// that meet the system's validation requirements.
    /// </summary>
    /// <returns>A valid Sale entity with randomly generated data.</returns>
    public static CreateSaleCommand GenerateValidCommand()
    {
        return createSaleHandlerFaker.Generate();
    }
}
