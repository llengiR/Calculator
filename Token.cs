namespace Calculator.Model.Tokens

/// <summary>
/// Base class for numbers and operators
/// </summary>
{
    public abstract class Token 
    {
        /// <summary>
        /// How the token should look like as text.
        /// </summary>
        /// <returns>The token as a string.</returns>
        public abstract override string ToString();
    }
}
