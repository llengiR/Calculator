namespace Calculator.Model
{
    /// <summary>
    /// Defines a stack where you can change or implement new featsures
    /// without having to change the rest of the code.
    /// </summary>
    /// <typeparam name="T">Represents the type of element stored in the stack.</typeparam>
    public interface IStack<T>
    {
        /// <summary>
        /// Add item on top of stack.
        /// </summary>
        /// <param name="item">The item that's pushed onto the stack.</param>
        void Push(T item);

        /// <sumary>
        /// Remove and return top item from stack
        /// </summary>
        T Pop();

        /// <summary>
        /// Check if stack is empty
        /// </summary>
        bool IsEmpty { get; }

        /// <summary>
        /// Number of items in the stack
        /// </summary>
        int Count { get; }
    }
      
}
