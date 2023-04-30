﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructureProblems274
{
    internal class GenericCustomeStack<T>
    {
            public Node<T> top;
            public GenericCustomeStack()
            {
                this.top = null;
            }
            public void Push(T value)
            {
                Node<T> node = new Node<T>(value);
                if (this.top == null)
                {
                    node.Next = null;
                }
                else
                {
                    node.Next = this.top;
                }
                this.top = node;
                Console.WriteLine("{0} pushed to stack", value);
            }
            public void Peek()
            {
                if (this.top == null)
                {
                    Console.WriteLine("Stack is Empty");
                    return;
                }
                Console.WriteLine("{0} is in the top of the stack", this.top.data);
            }
            public void Pop()
            {
                if (this.top == null)
                {
                    Console.WriteLine("Stack is Empty");
                    return;
                }
                Console.WriteLine("Value Popped is {0}", this.top.data);
                this.top = this.top.Next;
            }

            public void Display()
            {
                Node<T> temp = this.top;
                Console.WriteLine("Stack is as:");
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.Next;
                }
            }
        }
    }


