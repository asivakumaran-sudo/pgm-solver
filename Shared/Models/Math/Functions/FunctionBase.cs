namespace pgm_solver.Client.Shared;

/// <summary>
/// Base class for all function implementations.
/// </summary>
/// <typeparam name="TRange">The data type for the output of the function.</typeparam>
/// <typeparam name="TDomain">The data type for the input to the function.</typeparam>
public abstract class FunctionBase<TDomain, TRange>: IFunction<TDomain, TRange>
{
    /// <summary>
    /// Initializes an instance of <see cref="FunctionBase{TRange,TDomain}"/>
    /// </summary>
    /// <param name="function">The underlying mathematical function.</param>
    /// <param name="domain">The domain over which the function exists.</param>
    public FunctionBase(Func<TDomain[], TRange> function, IAxis<TDomain> domain)
    {
        this.Function = function;
        this.Domain = domain;
    }
    
    /// <inheritdoc cref="IFunction{TRange,TDomain}"/>
    public Func<TDomain[], TRange> Function { get; set; }
    
    /// <inheritdoc cref="IFunction{TRange,TDomain}"/>
    public IAxis<TDomain> Domain { get; init; }

    /// <inheritdoc cref="IFunction{TRange,TDomain}"/>
    public abstract double Measure();

    /// <summary>
    /// Defines how the function is added with other functions.
    /// </summary>
    /// <returns>The sum of this function with the other function.</returns>
    protected abstract FunctionBase<TDomain, TRange> Add(FunctionBase<TDomain, TRange> other);
    
    /// <summary>
    /// Defines how the function is subtracted from another functions.
    /// </summary>
    /// <returns>The difference between this function and the other function.</returns>
    protected abstract FunctionBase<TDomain, TRange> Subtract(FunctionBase<TDomain, TRange> other);
    
    /// <summary>
    /// Defines how the function is multiplied by another functions.
    /// </summary>
    /// <returns>The product this function and the other function.</returns>
    protected abstract FunctionBase<TDomain, TRange> Multiply(FunctionBase<TDomain, TRange> other);
    
    /// <summary>
    /// Defines how the function is divided by another functions.
    /// </summary>
    /// <returns>The quotient for this function and the other function.</returns>
    protected abstract FunctionBase<TDomain, TRange> Divide(FunctionBase<TDomain, TRange> other);

    /// <summary>
    /// Evaluates the mathematical function for the given arguments.
    /// </summary>
    /// <param name="arguments">The arguments with which the function is evaluated.</param>
    /// <returns>The output for the function at the given arguments.</returns>
    public TRange Evaluate(TDomain[] arguments) => Function.Invoke(arguments);

    /// <summary>
    /// Binds the addition operator to the <see cref="Add"/> function.
    /// </summary>
    /// <param name="a">The augend.</param>
    /// <param name="b">The addend.</param>
    /// <returns>The sum of the inputs.</returns>
    public static FunctionBase<TDomain, TRange> operator +(FunctionBase<TDomain, TRange> a,
        FunctionBase<TDomain, TRange> b)
        => a.Add(b);
    
    /// <summary>
    /// Binds the subtraction operator to the <see cref="Subtract"/> function.
    /// </summary>
    /// <param name="a">The minuend.</param>
    /// <param name="b">The subtrahend.</param>
    /// <returns>The sum of the inputs.</returns>
    public static FunctionBase<TDomain, TRange> operator -(FunctionBase<TDomain, TRange> a,
        FunctionBase<TDomain, TRange> b)
        => a.Subtract(b);
    
    /// <summary>
    /// Binds the multiplication operator to the <see cref="Multiply"/> function.
    /// </summary>
    /// <param name="a">The multiplier.</param>
    /// <param name="b">The multiplicant.</param>
    /// <returns>The product of the inputs.</returns>
    public static FunctionBase<TDomain, TRange> operator *(FunctionBase<TDomain, TRange> a,
        FunctionBase<TDomain, TRange> b)
        => a.Multiply(b);
    
    /// <summary>
    /// Binds the division operator to the <see cref="Multiply"/> function.
    /// </summary>
    /// <param name="a">The dividend.</param>
    /// <param name="b">The divisor.</param>
    /// <returns>The product of the inputs.</returns>
    public static FunctionBase<TDomain, TRange> operator /(FunctionBase<TDomain, TRange> a,
        FunctionBase<TDomain, TRange> b)
        => a.Divide(b);
}
