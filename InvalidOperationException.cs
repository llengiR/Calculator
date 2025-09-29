namespace Calculator.Model.Exceptions
{
    public class InvalidOperationException : Exception
    {
        //Creates standard error message
        public InvalidOperationException()
        : base("InvalidOperationException")
        {
        }

        // create error with costum message
        public InvalidOperationException(string message)
        : base(message)
        {
        }

        // shows error message 
        public override string ToString()
        {
            return Message;
        }
    }
}
