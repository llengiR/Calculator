namespace Calculator.Model.Exceptions

{
    /// <summary>
    /// Exception that is executed when an invalid token is given in the input.
    /// </summary>
    public class InvalidTokenException : Exception
    {
        /// <summary>
        /// Stores bad text that caused the problem
        /// </summary>
        public string InvalidInput { get; }

        /// <summary>
        /// Creates a new <see cref="InvalidTokenException"/> for the invalid token.
        /// </summary>
        /// <param name="invalidInput">The token that is invalid.</param>
        public InvalidTokenException(string invalidInput)
        : base ($"InvalidTokenException: '{invalidInput}' is not at valid token")
        {
            InvalidInput = invalidInput; //save bad text
        }

        /// <summary>
        /// Returns a string showing an error message.
        /// </summary>
        /// <returns>A string containing the exception and and error message.</returns>
        public override string ToString()
        {
            return $"InvalidTokenException: '{InvalidInput}' is not a valid token"; 
        }
    }
}

