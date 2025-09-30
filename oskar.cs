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
        : base ($"Exception: Divide by zero: {dividend,5:F2}/{divisor,5:F2}")
        {
            Dividend = dividend; //save left number
            Divisor = divisor; //save right number (zero)
        }

        public override string ToString()
        {
            // display error
            return $"Exception: Divide by zero: {Dividend,5:F2}/{Divisor,5:F2}";
        }
    }
}
