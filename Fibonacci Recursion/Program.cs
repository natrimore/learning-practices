using System;

namespace Fibonacci_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            var fib = Fib(3);

            Console.WriteLine(fib);
        }

        static int Fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            return Fib(n - 1) + Fib(n - 2);
        }

        static int Fact(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            return n * Fact(n - 1);
        }
    }
}
