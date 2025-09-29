namespace Calculator.Model.Exceptions
{
    /// <summary>
    /// Represents a error that occurs when giving the calculator an invalid input.
    /// </summary>
    public class InvalidOperationException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidOperationException"/> class
        /// with a default error message.
        /// </summary>
        public InvalidOperationException()
        : base("InvalidOperationException")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidOperationException"/> class
        /// with a custom error message.
        /// </summary>
        /// <param name="message">Error message explaning the reason for the exception.</param>
        public InvalidOperationException(string message)
        : base(message)
        {
        }

        /// <summary>
        /// Returns a string the represents the used exception.
        /// </summary>
        /// <returns>A string contaning the thrown exception and its message.</returns>
        public override string ToString()
        {
            return Message;
        }
    }
}

