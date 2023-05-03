using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems274
{
    internal class BuiltInQueue
    {
        public void Queue()
        {
            // Create a new queue
            Queue<string> queue = new Queue<string>();

            // Add items to the queue
            queue.Enqueue("apple");
            queue.Enqueue("banana");
            queue.Enqueue("cherry");

            // Read items from the queue
            foreach (string fruit in queue)
            {
                Console.WriteLine(fruit);
            }

            // Update the front item in the queue
            if (queue.Count > 0)
            {
                string frontItem = queue.Dequeue(); // remove the front item from the queue
                frontItem = "orange"; // modify the front item
                queue.Enqueue(frontItem); // add the modified front item to the back of the queue
            }

            // Delete an item from the queue
            if (queue.Contains("banana"))
            {
                Queue<string> tempQueue = new Queue<string>();
                while (queue.Count > 0)
                {
                    string item = queue.Dequeue();
                    if (item != "banana")
                    {
                        tempQueue.Enqueue(item);
                    }
                }
                while (tempQueue.Count > 0)
                {
                    queue.Enqueue(tempQueue.Dequeue());
                }
            }

            // Read items from the queue again
            foreach (string fruit in queue)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
   
