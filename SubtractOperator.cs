namespace Calculator.Model.Tokens

{
    /// <summary>
    /// Represents the subtraction operator (-) 
    /// </summary>
    public class SubtractOperator : Operator
    {
        /// <summary>
        /// Creates a subtraction operator
        /// </summary>
        public SubtractOperator() : base("-")
        {
        }

    /// <summary>
    /// subtract second number from first number
    /// </summary>
    /// <param name="left">The first number.</param>
    /// <param name="right">The second number.</param>
    /// <returns>The result of left - right.</returns>
    public override double Calculate(double left, double right)
    {
        return left - right; 
    }
    }
}
