using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems274
{
    internal class BuiltInLinkedList
    {
        public void LinkedList()
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            // Add nodes to the linked list
            linkedList.AddLast(23);
            linkedList.AddLast(34);
            linkedList.AddLast(45);

            // Read nodes from the linked list
            foreach (int num in linkedList)
            {
                Console.WriteLine(num);
            }

            // Update a node in the linked list
            LinkedListNode<int> node = linkedList.Find(34);
            if (node != null)
            {
                node.Value = 28;
            }

            // Delete a node from the linked list
            linkedList.Remove(45);

            // Read nodes from the linked list again
            foreach (int num in linkedList)
            {
                Console.WriteLine(num);
            }
        }
    }
}
