using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;
            int sv = int.Parse(Console.ReadLine());
            int[] arr = { 5, 3, 2, 4, 5, 7, 9, 30, 55 };
            int S = 0;
            int E = arr.Length - 1;
            bool check = false;

            while (S <= E)
            {
                if (arr[S] == sv || arr[E] == sv)
                {
                    Console.WriteLine("Found");
                    check = true;
                    break;
                }
                m = (S + E) / 2;
                if (sv == arr[m])
                {
                    Console.WriteLine("Found");
                    check = true;
                    break;
                }
                else if (sv > arr[m])
                {
                    S = m + 1;
                    if (arr[S] == sv)
                    {
                        Console.WriteLine("Found");
                        check = true;
                        break;
                    }
                }
                else if (sv < arr[m])
                {
                    E = m - 1;
                    if (arr[E] == sv)
                    {
                        Console.WriteLine("Found");
                        check = true;
                        break;
                    }
                }
            }
            if (check == false)
                Console.WriteLine("Not Found");
        }
    }
}
