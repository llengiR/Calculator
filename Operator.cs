namespace Calculator.Model.Tokens

{
    // all math operations
    public abstract class Operator : Token
    {
        // what symbol
        public string Symbol {get; }

        //giver operator the written symbol
        protected Operator(string symbol)
        {
            Symbol = symbol;
        }

        // create first and seccond number
        public abstract double Calculate(double left, double right);

        // show operator as text
        public override string ToString()
        {
            return Symbol;
        }
    }
}