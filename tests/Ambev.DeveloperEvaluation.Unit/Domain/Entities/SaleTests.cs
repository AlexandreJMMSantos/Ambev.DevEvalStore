using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Unit.Domain.Entities.TestData;
using Xunit;
using System;

namespace Ambev.DeveloperEvaluation.Unit.Domain.Entities;

/// <summary>
/// Contains unit tests for the Sale entity class.
/// Tests cover property assignment and business logic scenarios.
/// </summary>
public class SaleTests
{
    /// <summary>
    /// Tests that a valid Sale entity can be created without validation errors.
    /// </summary>
    [Fact(DisplayName = "Sale should be created with valid data")]
    public void Given_ValidSaleData_When_Created_Then_ShouldContainCorrectValues()
    {
        // Arrange
        var sale = SaleTestData.GenerateValidSale();
        var now = DateTime.UtcNow;

        // Assert
        Assert.NotNull(sale);
        Assert.False(string.IsNullOrEmpty(sale.SaleNumber));
        Assert.NotEqual(Guid.Empty, sale.ChartId);
        Assert.NotEqual(Guid.Empty, sale.UserId);
        Assert.NotEqual(Guid.Empty, sale.ProductId);
        Assert.True(sale.Quantity > 0);
        Assert.True(sale.UnitPrice > 0);
        Assert.True(sale.Discount >= 0);
        Assert.Equal((sale.Quantity * sale.UnitPrice) - sale.Discount, sale.TotalAmount);

        // Act
        Assert.True(sale.SaleDate <= now,
            $"SaleDate ({sale.SaleDate}) não pode estar no futuro.");
    }

    /// <summary>
    /// Tests that a Sale entity with invalid data still gets created (since there is no validation method).
    /// </summary>
    [Fact(DisplayName = "Sale should allow creation even with invalid data")]
    public void Given_InvalidSaleData_When_Created_Then_ShouldContainDefaultValues()
    {
        // Arrange
        var sale = new Sale();
        var now = DateTime.UtcNow;

        // Assert
        Assert.NotNull(sale);
        Assert.Equal(string.Empty, sale.SaleNumber);
        Assert.Equal(Guid.Empty, sale.ChartId);
        Assert.Equal(Guid.Empty, sale.UserId);
        Assert.Equal(Guid.Empty, sale.ProductId);
        Assert.Equal(0, sale.Quantity);
        Assert.Equal(0, sale.UnitPrice);
        Assert.Equal(0, sale.Discount);
        Assert.Equal(0, sale.TotalAmount);

        // Act
        Assert.True(sale.SaleDate <= now,
            $"SaleDate ({sale.SaleDate}) não pode estar no futuro.");
    }
}
