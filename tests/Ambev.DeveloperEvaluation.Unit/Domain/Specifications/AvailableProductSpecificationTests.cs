using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Specifications;
using Ambev.DeveloperEvaluation.Unit.Domain.Specifications.TestData;
using FluentAssertions;
using Xunit;

namespace Ambev.DeveloperEvaluation.Unit.Domain.Specifications;

/// <summary>
/// Tests for the AvailableProductSpecification.
/// Ensures that only products with valid price and category are available for sale.
/// </summary>
public class AvailableProductSpecificationTests
{
    [Theory]
    [InlineData(100, "Electronics", true)]  // Product with price and category → Available
    [InlineData(0, "Electronics", false)]   // Product with no price → Not available
    [InlineData(50, "", false)]             // Product with no category → Not available
    [InlineData(0, "", false)]              // Product with no price and category → Not available
    public void IsSatisfiedBy_ShouldValidateProductAvailability(decimal price, string category, bool expectedResult)
    {
        // Arrange
        var product = AvailableProductSpecificationTestData.GenerateProduct(price, category);
        var specification = new AvailableProductSpecification();

        // Act
        var result = specification.IsSatisfiedBy(product);

        // Assert
        result.Should().Be(expectedResult);
    }
}
