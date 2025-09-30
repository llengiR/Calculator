namespace Calculator.Model.Tokens

{
    // handles two numbers by subtracting them
    public class SubtractOperator : Operator
    {
        // new subtraction operator
        public SubtractOperator() : base("-")
        {
        }

        // subtract second number from first number
    public override double Calculate(double left, double right)
    {
        return left - right; 
    }
    }
}
