using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructureProblems274
{
    internal class GenericQueue<T>
    {
        Node<T> head = null;
        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine("{0} is inserted into Queue", node.data);
        }
        public void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is Empty.So Deletion is not Possible");
                return;
            }
            else
            {
                this.head = this.head.Next;
                Console.WriteLine("Removed the element from queue");

            }
        }
        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            Console.WriteLine("Queue is as:");
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.Next;
            }
        }
    }
}
