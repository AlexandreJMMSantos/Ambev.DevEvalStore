using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Specifications;

/// <summary>
/// Specification to check if a sale is completed (i.e., not cancelled).
/// </summary>
public class CompletedSalesSpecification
{
    /// <summary>
    /// Determines whether a given sale is considered completed.
    /// </summary>
    /// <param name="sale">The sale entity to check.</param>
    /// <returns>True if the sale is not cancelled, otherwise false.</returns>
    public bool IsSatisfiedBy(Sale sale)
    {
        return sale != null && !sale.IsCancelled;
    }
}
