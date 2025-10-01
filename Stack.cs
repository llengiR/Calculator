using System.Collections.Generic;
namespace Calculator.Model
{
    /// <summary>
    /// A stack (last in, first out).
    /// push adds to the top of the stack, pop takes from the top.
    /// </summary>
    /// <typeparam name="T">The type of item being held in the stack.</typeparam>
    public class Stack<T> : IStack<T>
    {
        // internal list to store items
        private List <T> items;

        /// <summary>
        /// Creates a empty stack.
        /// </summary>
        public Stack()
        {
            // create new empty list to hold stacked items
            items = new List<T>();
        }

        /// <summary>
        /// Add new item to top of the stack
        /// </summary>
        /// <param name="item">The item to add to the stack.</param>
        public void Push(T item)
        {
            items.Add(item);
        }

        /// <summary>
        /// Remove and return the top item in stack
        /// </summary>
        /// <returns>The item on top of the stack.</returns>
        /// <exception name="InvalidOperationException">Thrown if the stack is empty.</exception>
        public T Pop()
        {
            // Check if stack i empty
            if(IsEmpty)
            {
                // throw error if pop the empty stack
                throw new InvalidOperationException("Cannot pop from empty stack");
            }

            // Get the top of stack
            T topItem = items[items.Count - 1];

            //Remove from list
            items.RemoveAt(items.Count - 1);

            //return removes item
            return topItem;
        }

        /// <summary>
        /// Check if the stack has items
        /// <summary>
        public bool IsEmpty
        {
            get
            {
                // stack is empty when list = 0
                return items.Count == 0;
            }
        }

        /// <summary>
        /// Counts how many items currently are in the stack.
        /// </summary>
        public int Count
        {
            get
            {
                return items.Count;
            }
        }
    }
}
