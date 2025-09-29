using System.Collections.Generic;
namespace Calculator.Model
{
    public class Stack<T> : IStack<T>
    {
        // internal list to store items
        private List <T> items;

        //constructor, empty stack
        public Stack()
        {
            // create new empty list to hold stacked items
            items = new List<T>();
        }

        // Add new item to top of the stack
        public void Push(T item)
        {
            items.Add(item);
        }

        // Remove and retur the top item in stack
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

        //check if the stack has items
        public bool IsEmpty
        {
            get
            {
                // stack is empty when list = 0
                return items.Count == 0;
            }
        }

        // tells how many items in stack
        public int Count
        {
            get
            {
                return items.Count;
            }
        }
    }
}