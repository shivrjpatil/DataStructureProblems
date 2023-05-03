using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems274
{
    internal class BuiltInStack
    {
        public void Stack()
        {
            // Create a new stack
            Stack<string> stack = new Stack<string>();

            // Add items to the stack
            stack.Push("apple");
            stack.Push("banana");
            stack.Push("cherry");

            // Read items from the stack
            foreach (string fruit in stack)
            {
                Console.WriteLine(fruit);
            }

            // Update the top item on the stack
            if (stack.Count > 0)
            {
                stack.Peek(); // peek at the top item without removing it
                stack.Pop(); // remove the top item from the stack
                stack.Push("orange"); // push a new item to the top of the stack
            }

            // Delete an item from the stack
            if (stack.Contains("banana"))
            {
                Stack<string> tempStack = new Stack<string>();
                while (stack.Count > 0)
                {
                    string item = stack.Pop();
                    if (item != "banana")
                    {
                        tempStack.Push(item);
                    }
                }
                while (tempStack.Count > 0)
                {
                    stack.Push(tempStack.Pop());
                }
            }

            // Read items from the stack again
            foreach (string fruit in stack)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
