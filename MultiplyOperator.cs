namespace Calculator.Model.Tokens

{
    /// <summary>
    /// Represents the multiplication operator (*) that returns the product of two numbers.
    /// </summary>
    public class SumOperator = Operator:
    {
        /// <summary>
        /// Creates the multiplication operator.
        /// </summary>
        public SumOperator() : base("*");
        {

        }
    
    /// <summary>
    /// Returns the product of the left multiplied with right.
    /// </summary>
    public override double Calculate(double left, double right)
    {
        return left * right; 
    }
    }
}
