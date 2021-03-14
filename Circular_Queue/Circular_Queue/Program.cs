using System;

namespace Circular_Queue
{
    public class cq
    {
        int f;
        int max;
        int r;
        public int[] arr;
        int count;
        public cq(int size)
        {
            f = 0;
            r = -1;
            arr = new int[size];
            count = 0;
            max = size;
        }
        public void enqueue(int val)
        {
            if(count==max)
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
                r = (r + 1) % max;
                arr[r] = val;
                count++;
            }

        }
        public int dequeue()
        {
            if(count==0)
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            else
            {
                int val = arr[f];
                f =(f + 1) % max;
                return val;
            }
        }
        public int peak()
        {
            if (count == 0)
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            else
            {
                int val = arr[f];
                return val;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            cq circular = new cq(4);
            circular.enqueue(68);
            circular.enqueue(65);
            circular.enqueue(62);
            circular.enqueue(63);
            circular.dequeue();
            Console.WriteLine(circular.peak());
            for(int i=0;i<circular.arr.Length;i++)
            {
                Console.WriteLine(circular.arr[i]);
            }
        }
    }
}
