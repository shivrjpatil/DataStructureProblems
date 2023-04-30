using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructureProblems274
{
    internal class GenericClassCustomLinkedList<T>
    {
        Node<T> head;
        public void AddNode(T data)
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
            Console.WriteLine("{0} inserted into linkedlist", node.data);
        }

        public void AddReverseData(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node<T> temp = this.head;
                head = newNode;
                head.Next = temp;
            }
        }

        public void PopLast()
        {
            Node<T> tempnode = head;
            Node<T> lastnode = tempnode.Next;
            if (head.Next != null)
            {
                tempnode = tempnode.Next;
                tempnode.Next = null;
                lastnode = null;
            }
        }
        public void dispaly()
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                Node<T> tempnode = head;

                while (tempnode != null)
                {
                    Console.WriteLine(tempnode.data);
                    tempnode = tempnode.Next;
                }
            }
        }
    }
}

