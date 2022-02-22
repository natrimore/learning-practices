using System;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++) {
                arr[i] = 1 << i;

                System.Console.WriteLine(arr[i]);
            }
        }
    }
}
