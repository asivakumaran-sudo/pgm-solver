namespace pgm_solver.Client.Shared;

public class ContinuousFunction : FunctionBase<double, double>
{
    // /// <summary>
    // /// Initializes an instance of ContinuousFunction.
    // /// </summary>
    // /// <param name="function"></param>
    // private ContinuousFunction(Func<double[], double> function, IContinuousAxis domain)
    // {
    //     this.Function = function;
    //     this.Domain = domain;
    //     
    // }

    public ContinuousFunction(Func<double[], double> function, IAxis<double> domain)
        : base(function, domain)
    {
    }

    /// <inheritdoc cref="FunctionBase{TDomain,TRange}"/>
    public override double Measure()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc cref="FunctionBase{TDomain,TRange}"/>
    protected override FunctionBase<double, double> Add(FunctionBase<double, double> other)
    {
        // TODO: Figure this out.
        // var axis = AxisFactory.CreateContinuousPiecewiseAxis(new[] { this.Domain, other.Domain });
        // var sum = (double[] input) =>
        // {
        //     
        // }
        throw new NotImplementedException();
    }

    /// <inheritdoc cref="FunctionBase{TDomain,TRange}"/>
    protected override FunctionBase<double, double> Subtract(FunctionBase<double, double> other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc cref="FunctionBase{TDomain,TRange}"/>
    protected override FunctionBase<double, double> Multiply(FunctionBase<double, double> other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc cref="FunctionBase{TDomain,TRange}"/>
    protected override FunctionBase<double, double> Divide(FunctionBase<double, double> other)
    {
        throw new NotImplementedException();
    }
}
