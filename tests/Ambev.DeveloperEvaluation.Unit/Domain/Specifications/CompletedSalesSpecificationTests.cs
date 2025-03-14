using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Specifications;
using Ambev.DeveloperEvaluation.Unit.Domain.Specifications.TestData;
using FluentAssertions;
using Xunit;

namespace Ambev.DeveloperEvaluation.Unit.Domain.Specifications
{
    /// <summary>
    /// Contains unit tests for the CompletedSaleSpecification class.
    /// Tests verify whether a sale meets the required criteria for a "completed" status.
    /// </summary>
    public class CompletedSalesSpecificationTests
    {
        [Theory]
        [InlineData(false, true)] // Não cancelada → Deve ser considerada válida
        [InlineData(true, false)] // Cancelada → Deve ser considerada inválida
        public void IsSatisfiedBy_ShouldValidateSaleCompletionStatus(bool isCancelled, bool expectedResult)
        {
            // Arrange
            var sale = CompletedSalesSpecificationTestData.GenerateSale(isCancelled);
            var specification = new CompletedSalesSpecification();

            // Act
            var result = specification.IsSatisfiedBy(sale);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
