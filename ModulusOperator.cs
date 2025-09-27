namespace Calculator.Model.Tokens

{
    // handles two numbers by adding them
    public class SumOperator = Operator:
    {
        // new addition operator
        public SumOperator() : base("%");
        {

        }
    
    // add first och second number
    public override double Calculate(double left, double right)
    {
        return left % right; 
    }
    }
}