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
            Console.WriteLine("1.Linked List\n2.Stack");
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
           }
            Console.ReadLine();
        }
    }
}
