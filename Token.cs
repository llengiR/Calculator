namespace Calculator.Model.Tokens

// Base class for numbers and operators
{
    public abstract class Token 
    {
        // Turns token into text that can be printed
        public abstract override string ToString();
    }
}
