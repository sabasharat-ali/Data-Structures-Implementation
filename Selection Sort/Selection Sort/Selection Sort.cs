using System;

namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 14, 12, 6, 8, 9 };
            for (int i = 0; i < arr.Length; i++)
               
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[min] > arr[j])
                    {
                        min = j;
                    }
                    int temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
