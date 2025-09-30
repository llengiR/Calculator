namespace Calculator.Model.Tokens

{
    /// <summary>
    /// all math operations (-,+,*,%,/).
    /// </summary>
    public abstract class Operator : Token
    {
        /// <summary>
        /// Gets the symbol that is being used.
        /// </summary>
        public string Symbol {get; }

        /// <summary>
        /// Makes a new operator with the given symbol.
        /// </summary>
        /// <param name="symbol">The text for the operator.</param>
        protected Operator(string symbol)
        {
            Symbol = symbol;
        }

        /// <summary>
        /// Does the math with two numbers.
        /// </summary>
        /// <param name="left">The first number given.</param>
        /// <param name="right">The second number given.</param>
        /// <returns>The result of the operation.</returns>
        public abstract double Calculate(double left, double right);

        /// <summary>
        /// show the operator as a text.
        /// </summary>
        /// <returns>The operator symbol.</returns>
        public override string ToString()
        {
            return Symbol;
        }
    }
}
