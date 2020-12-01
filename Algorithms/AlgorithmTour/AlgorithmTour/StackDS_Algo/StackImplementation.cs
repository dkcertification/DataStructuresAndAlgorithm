using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTour.StackDS_Algo
{
    class StackImplementationUsingArrays
    {
        int MAX = 100;
        int top;
        int[] stack;

        public StackImplementationUsingArrays(int sizeofStack)
        {
            top = -1;
            MAX = sizeofStack;
            stack = new int[MAX];
        }

        bool IsEmpty()
        {
            return (top < 0);
        }

        public bool Push(int data)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }

        public int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                int value = stack[top--];
                return value;
            }
        }


        public void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
                Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
        }

        public void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
}
