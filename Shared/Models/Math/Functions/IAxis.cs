namespace pgm_solver.Client.Shared;

/// <summary>
/// An axis in a euclidean space.
/// </summary>
/// <typeparam name="T">The units used for the axis.</typeparam>
public interface IAxis<T>
{
    /// <summary>
    /// The minimum value for the axis.
    /// </summary>
    T Min { get; init; }
    
    /// <summary>
    /// The maximum value for the axis.
    /// </summary>
    T Max { get; init; }
}

/// <summary>
/// A discrete axis.
/// </summary>
public interface IDiscreteAxis : IAxis<int> { }

/// <summary>
/// A continuous axis.
/// </summary>
public interface IContinuousAxis : IAxis<double> { }
