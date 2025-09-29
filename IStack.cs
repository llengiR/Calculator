namespace Calculator.Model
{
    // how the stack should work. Using interface if wantinf to change stack
    public interface IStack<T>
    {
        // Add item on top of stack
        void Push(T item);

        // Remove and return top item from stack
        T Pop();

        // Check if stack is empty
        bool IsEmpty { get; }

        // Number of items
        int Count { get; }
    }
      
}