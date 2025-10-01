namespace Calculator.Model.Tokens

{
    /// <summary>
    /// Represents the addition operator (+), adds two numbers together.
    /// </summary>
    public class SumOperator : Operator
    {
        /// <summary>
        /// Creates the addition operator.
        /// </summary>
        public SumOperator() : base("+")
        {

        }
    
    /// <summary>
    /// adds the second number to the first number.
    /// </summary>
    /// <param name="left">The first number.</param>
    /// <param name="right">The second number.</param>
    /// <returns>The sum of left + right.</returns>
    public override double Calculate(double left, double right)
    {
        return left + right; 
    }
    }
}
