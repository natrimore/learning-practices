using System;

namespace For20
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1! -> 1
            // 2! -> 1*2
            // 3! -> 1*2*3
            // 4! -> 1*2*3*4
            // 1! + 2! + 3! + 4!

            int n = int.Parse(Console.ReadLine());

            long sum = 0;
            long fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                sum += fact;
            }

            Console.WriteLine(sum);
        }
    }
}
