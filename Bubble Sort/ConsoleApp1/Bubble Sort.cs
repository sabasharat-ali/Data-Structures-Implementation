using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 5, 6, 10,  18 };

            for (int i = 0; i < A.Length - 1; i++)

            {
                bool check = false;
                for (int j = 0; j < A.Length - 1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        check = true;
                        int temp = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = temp;
                     
                    }
                    if (check == false)
                    {
                        break;
                    }
                }
            }
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i]);
            }
        }
    }
}
