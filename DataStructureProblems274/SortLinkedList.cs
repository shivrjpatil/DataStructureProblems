using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems274
{
    internal class SortLinkedList
    {
        public void SortList()
        {
            LinkedList<int> sortedList = new LinkedList<int>();

            // Add items to the sorted list in descending order
            sortedList.AddFirst(10);
            sortedList.AddFirst(7);
            sortedList.AddFirst(5);
            sortedList.AddFirst(3);

            // Insert a new item in the correct position in the sorted list
            int newItem = 6;
            LinkedListNode<int> currentNode = sortedList.First;
            while (currentNode != null && currentNode.Value > newItem)
            {
                currentNode = currentNode.Next;
            }
            if (currentNode != null)
            {
                sortedList.AddBefore(currentNode, newItem);
            }
            else
            {
                sortedList.AddLast(newItem);
            }

            // Print out the sorted list
            foreach (int item in sortedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
