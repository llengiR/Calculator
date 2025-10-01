using Calculator.Model.Exceptions;
using DivideByZeroException = Calculator.Model.Exceptions.DivideByZeroException;
namespace Calculator.Model.Tokens

{
    /// <summary>
    /// An division operator (/) that divides one number by the other.
    /// </summary>
    public class DivideOperator : Operator
    {
        /// <summary>
        /// Initializes new instance of <see cref="DivideOperator"/> class.
        /// And registers its symbol with the base <see cref="Operator"/>.
        /// </summary>
        public DivideOperator() : base("/")
        {
            
        }
    
    /// <summary>
    /// calculates the quotient of two numbers.
    /// </summary>
    /// <param name="left">The left-hand number.</param>
    /// <param name="right">The right-hand number.</param>
    /// <returns>The resulting qoutient of <param name="left"/> / <param name="right"/>.</returns>
    public override double Calculate(double left, double right)
    {
        if(right == 0)
        {
            throw new DivideByZeroException(left, right);
        }
        return left / right;
    }
    }
}
