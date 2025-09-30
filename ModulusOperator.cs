namespace Calculator.Model.Tokens

{
    /// <summary>
    /// Represents the modulo operator (%) that returns the remainder a division.
    /// </summary>
    public class SumOperator = Operator:
    {
        /// <summary>
        /// Creates a modulo operator.
        /// </summary>
        public SumOperator() : base("%");
        {

        }
    
    /// <summary>
    /// Returns the remainder of left divided by right.
    /// </summary>
    /// <returns>The value of the remainder.</returns>
    public override double Calculate(double left, double right)
    {
        return left % right; 
    }
    }
}
