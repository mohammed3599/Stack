using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Stack
    {
        private int[] stack;
        private int top;

        public Stack(int n)
        {
            this.stack = new int[n];
            top = -1;
        }

        public void Push(int number)
        {
            if (top >= stack.Length - 1)
            {
                Console.WriteLine("Stack is full");
                return;
            }
            stack[++top] = number;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            return stack[top--];
        }

        public int peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
            }
            return stack[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        private bool IsFull()
        {
            return top == 0;
        }


    }
}
