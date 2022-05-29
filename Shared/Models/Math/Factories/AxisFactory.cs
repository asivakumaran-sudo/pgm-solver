namespace pgm_solver.Client.Shared;

/// <summary>
/// Factory class for generating axes.
/// </summary>
public static class AxisFactory
{
    public class ContinuousAxis : IContinuousAxis
    {
        public ContinuousAxis(double min, double max)
        {
            this.Min = min;
            this.Max = max;
        }
        
        public double Min { get; init; }
        
        public double Max { get; init; }
    }
    
    public class ContinuousPiecewiseAxis : IContinuousPiecewiseAxis
    {
        public ContinuousPiecewiseAxis(IEnumerable<IAxis<double>> axes)
        {
            this.ValidateAxes(axes);
            this.Axes = axes;
            // axes.Min(a => )
        }
        
        /// <inheritdoc cref="IPiecewiseAxis{T}"/>
        public double Min { get; init; }
        
        /// <inheritdoc cref="IPiecewiseAxis{T}"/>
        public double Max { get; init; }
        
        /// <inheritdoc cref="IPiecewiseAxis{T}"/>
        public IEnumerable<IAxis<double>> Axes { get; init; }
        
        /// <inheritdoc cref="IPiecewiseAxis{T}"/>
        public bool ValidateAxes(IEnumerable<IAxis<double>> axes)
        {
            // TODO: Figure this out.
            // double min = double.PositiveInfinity;
            // double max = double.NegativeInfinity;
            // foreach (var axis in axes)
            // {
            //     if (axis.Min > min)
            //     {
            //         min = axis.Min;
            //     }
            //
            //     if (axis.Max < max)
            //     {
            //         max = axis.Max;
            //     }
            // }
            return true;
        }
    }

    public static ContinuousPiecewiseAxis CreateContinuousPiecewiseAxis(IEnumerable<IAxis<double>> axis)
        => new ContinuousPiecewiseAxis(axis);

    public static ContinuousAxis CreateContinuousAxis(double min, double max)
        => new ContinuousAxis(min, max);
}
