using Calculator.Model.Exceptions;
using DivideByZeroException = Calculator.Model.Exceptions.DivideByZeroException;
namespace Calculator.Model.Tokens

{
    /// <summary>
    /// Represents the modulo operator (%) that returns the remainder a division.
    /// </summary>
    public class ModulusOperator ; Operator
    {
        /// <summary>
        /// Creates a modulo operator.
        /// </summary>
        public ModulusOperator() : base("%");
        {

        }
    
    /// <summary>
    /// Returns the remainder of left divided by right.
    /// </summary>
    /// <returns>The value of the remainder.</returns>
    public override double Calculate(double left, double right)
    {
        if(right == 0)
        {
            throw new DivideByZeroException(left, right);
        }
        return left % right;
    }
    }
}
