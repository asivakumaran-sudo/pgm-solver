namespace pgm_solver.Client.Shared;

/// <summary>
/// A collection of axes with a common domain.
/// </summary>
/// <typeparam name="T">The units used for the axes.</typeparam>
public interface IPiecewiseAxis<T> : IAxis<T>
{
    /// <summary>
    /// Collection of axes that make up the piecewise domain.
    /// </summary>
    IEnumerable<IAxis<T>> Axes { get; init; }

    /// <summary>
    /// Method used to validate a piecewise domain.
    /// </summary>
    /// <returns>Indicator of a valid collection of axes.</returns>
    bool ValidateAxes(IEnumerable<IAxis<T>> axes);
}

public interface IDiscretePiecewiseAxis: IPiecewiseAxis<int> { }

public interface IContinuousPiecewiseAxis: IPiecewiseAxis<double> { }
