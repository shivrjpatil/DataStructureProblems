using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems274
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Linked List\n2.Stack\n3.Queue");
            int option = Convert.ToInt32(Console.ReadLine());
           switch (option)
           {
                case 1:
                GenericClassCustomLinkedList<int> linkedList = new GenericClassCustomLinkedList<int>();
                linkedList.AddNode(34);
                linkedList.AddNode(56);
                linkedList.AddNode(67);
                linkedList.AddReverseData(34);
                linkedList.AddReverseData(56);
                linkedList.AddReverseData(67);
                linkedList.dispaly();
                linkedList.PopLast();
                linkedList.dispaly();
                break;
                case 2:
                    GenericCustomeStack<int> stack = new GenericCustomeStack<int>();
                    stack.Push(23);
                    stack.Push(24);
                    stack.Push(35);
                    stack.Display();
                    stack.Peek();
                    stack.Pop();
                    stack.Pop();
                    stack.Display();
                    break;
                case 3:
                    GenericQueue<int> queue = new GenericQueue<int>();
                    queue.Enqueue(23);
                    queue.Enqueue(78);
                    queue.Enqueue(24);
                    queue.Display();
                    queue.Dequeue();
                    queue.Display();
                    GenericQueue<double> queue2 = new GenericQueue<double>();
                    queue2.Enqueue(2.3);
                    queue2.Enqueue(7.8);
                    queue2.Enqueue(2.4);
                    queue2.Display();
                    queue2.Dequeue();
                    queue2.Display();

                    GenericQueue<char> queue3 = new GenericQueue<char>();
                    queue3.Enqueue('a');
                    queue3.Enqueue('b');
                    queue3.Enqueue('c');
                    queue3.Display();
                    queue3.Dequeue();
                    queue3.Display();

                    break;
                   
           }
            Console.ReadLine();
        }
    }
}
