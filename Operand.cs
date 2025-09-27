namespace Calculator.Model.Tokens

{
    // number in RPN
    public class Operand : Token
    {
        // Stores the value of Operand
        public double Value { get; }
        
        //creates new operand with value
        public Operand(double value)
        {
            Value = value;
        }

        // returns value as string
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}