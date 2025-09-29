namespace Calculator.Model.Exceptions

{
    public class DivideByZeroException : Exception
    {
        // left operator
        public double Dividend { get; }
        // right operator 
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
