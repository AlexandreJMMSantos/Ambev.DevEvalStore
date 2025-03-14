using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Unit.Domain.Entities.TestData;
using Xunit;

namespace Ambev.DeveloperEvaluation.Unit.Domain.Entities;

/// <summary>
/// Contains unit tests for the Product entity class.
/// Tests cover property assignment and business logic scenarios.
/// </summary>
public class ProductTests
{
    /// <summary>
    /// Tests that a valid Product entity can be created without validation errors.
    /// </summary>
    [Fact(DisplayName = "Product should be created with valid data")]
    public void Given_ValidProductData_When_Created_Then_ShouldContainCorrectValues()
    {
        // Arrange
        var product = ProductTestData.GenerateValidProduct();

        // Assert
        Assert.NotNull(product);
        Assert.False(string.IsNullOrEmpty(product.Title));
        Assert.False(string.IsNullOrEmpty(product.Description));
        Assert.True(product.Price > 0);
        Assert.False(string.IsNullOrEmpty(product.Category));
        Assert.False(string.IsNullOrEmpty(product.Image));
        Assert.NotNull(product.Rating);
        Assert.True(product.Rating.Rate >= 0);
        Assert.True(product.Rating.Count >= 0);
    }

    /// <summary>
    /// Tests that a Product entity with invalid data still gets created (since there is no validation method).
    /// </summary>
    [Fact(DisplayName = "Product should allow creation even with invalid data")]
    public void Given_InvalidProductData_When_Created_Then_ShouldContainDefaultValues()
    {
        // Arrange
        var product = new Product();

        // Assert
        Assert.NotNull(product);
        Assert.Equal(string.Empty, product.Title);
        Assert.Equal(string.Empty, product.Description);
        Assert.Equal(0, product.Price);
        Assert.Equal(string.Empty, product.Category);
        Assert.Equal(string.Empty, product.Image);
        Assert.NotNull(product.Rating);
        Assert.Equal(0, product.Rating.Rate);
        Assert.Equal(0, product.Rating.Count);
    }
}
