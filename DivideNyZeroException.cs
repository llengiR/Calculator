namespace Calculator.Model.Exceptions

{
    ///<summary>
    /// Represents a exeption when trying to divde a number by zero.
    ///</summary>
    public class DivideByZeroException : Exception
    {
        ///<summary>
        /// Gets the left operator i.e the value being divided.
        ///</summary>
        public double Dividend { get; }
        ///<summary>
        /// Gets the right operator i.e the divisor. 
        /// Will be zero when the exeption is used.
        ///</summary>
        public double Divisor { get; }

        // set up error
        public DivideByZeroException(double dividend, double divisor)
        : base ($"DivideByZeroException: {dividend:F2}/{divisor:F2}")
        {
            Dividend = dividend; //save left number
            Divisor = divisor; //save right number (zero)
        }

        public override string ToString()
        {
            // display error
            return $"DivideByZeroException:{Dividend:F2}/{Divisor:F2}";
        }
    }
}

