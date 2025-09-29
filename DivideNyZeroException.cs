namespace Calculator.Model.Exceptions

{
    /// <summary>
    /// Represents a exeption used when trying to divde a number by zero.
    /// </summary>
    public class DivideByZeroException : Exception
    {
        /// <summary>
        /// Gets the left operator i.e the value being divided.
        /// </summary>
        public double Dividend { get; }
        
        /// <summary>
        /// Gets the right operator i.e the divisor. 
        /// Will be zero when the exeption is used.
        /// </summary>
        public double Divisor { get; }
        
        /// <summary>
        /// Initializes a new instance of <see cref="DivideByZeroException"/> class.
        /// </summary>
        /// <param> name="dividend">The value being divided.</param>
        /// <param name="divisor">The divisor which caused the issue.</param>
        public DivideByZeroException(double dividend, double divisor)
        : base ($"DivideByZeroException: {dividend:F2}/{divisor:F2}")
        {
            Dividend = dividend; //save left number.
            Divisor = divisor; //save right number (zero).
        }

        /// <summary>
        /// Returns a string representation of the exception.
        /// Displaying the division that caused the error.
        /// </summary>
        /// <returns>String with a error message.</returns>
        public override string ToString()
        {
            return $"DivideByZeroException:{Dividend:F2}/{Divisor:F2}";
        }
    }
}


