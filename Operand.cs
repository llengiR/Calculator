namespace Calculator.Model.Tokens

{
    /// <summary>
    /// Number used in the RPN calculations.
    /// </summary>
    public class Operand : Token
    {
        /// <summary>
        /// The actual number used in the calculator.
        /// </summary>
        public double Value { get; }

        /// <summary>
        /// Creates new operand with the used value.
        /// </summary>
        /// <param name="value">The number to store.</param>
        public Operand(double value)
        {
            Value = value;
        }

        /// <summary>
        /// Show the number as text.
        /// </summary>
        /// <returns>Returns the number as a string.</returns>
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
