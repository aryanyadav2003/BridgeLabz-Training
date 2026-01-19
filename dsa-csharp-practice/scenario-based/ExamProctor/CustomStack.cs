using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDiscountSort.ExamProctor
{
    internal class CustomStack
    {
        private int[] stack;
        private int top;
        private int capacity;
        public CustomStack(int size)
        {
            capacity = size;
            stack = new int[capacity];
            top = -1;
        }
        public void Push(int value)
        {
            if (top == capacity - 1)
            {
              Console.WriteLine("Navigation stack overflow");
              return;               
            }
            stack[++top] = value;
        }
        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Navigation stack underflow.");
                return -1;
            }
            return stack[top--];
        }
        public void Display()
        {
            for(int i = top; i >= 0; i--)
            {
                Console.WriteLine(stack[i] + " ");
            }
        }
    }
}
