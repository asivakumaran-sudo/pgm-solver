namespace pgm_solver.Client.Shared;

/// <summary>
/// Describes a mathematical function.
/// </summary>
public interface IFunction<TDomain, TRange>
{
    /// <summary>
    /// Gets the mathematical function/transformation.
    /// </summary>
    Func<TDomain[], TRange> Function { get; set; }

    /// <summary>
    /// Gets or sets the input domain for the mathematical function.
    /// </summary>
    IAxis<TDomain> Domain { get; init; }
    
    /// <summary>
    /// Evaluates the sum/integral over the domain of the function.
    /// </summary>
    /// <returns>The sum/integral over the domain of the function.</returns>
    double Measure();
}
