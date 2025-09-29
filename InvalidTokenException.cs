namespace Calculator.Model.Exceptions

{
    public class InvalidTokenException : Exception
    {
        // Stores bad text that caused the problem
        public string InvalidInput { get; }

        // creates the error and saves what text was wrong
        public InvalidTokenException(string invalidInput)
        : base ($"InvalidTokenException: '{invalidInput}' is not at valid token")
        {
            InvalidInput = invalidInput; //save bad text
        }

        //shows error message
        public override string ToString()
        {
            return $"InvalidTokenException: '{InvalidInput}' is not a valid token"; 
        }
    }
}
