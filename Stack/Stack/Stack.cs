using System;

namespace Stack
{
    public class sstack
    {
        int[] arr;
        int top;
        int max;
        public sstack(int size)
        {
            top = -1;
            arr = new int[size];
            max = size;
        }
        public void push(int val)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Overflow");
                
            }
            else
            {
                arr[++top] = val;
            }
        }
        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Empty");
                return -1;
            }
            else
            {
                int val = arr[top];
                top--;
                return val;
            }
        }
        public int Peak()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Empty");
                return -1;
            }
            else
            {
                int val = arr[top];
                return val;
            }
        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {
            sstack ss = new sstack(4);
            ss.push(8);
            ss.push(5);
            ss.Pop();
            Console.WriteLine(ss.Pop());
            
        }
    }
}
