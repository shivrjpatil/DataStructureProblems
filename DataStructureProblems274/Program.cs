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
            Console.ReadLine();
        }
    }
}
