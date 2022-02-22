using System;
using System.Text;

namespace For26
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string s = "Hello";

            s = s + " world!";

            s += " asdasdas";

            int y = unchecked(int.MaxValue + 1);

            Console.WriteLine(y);

            double r = 1e6;
            Console.WriteLine(r);
            int? b = 0b100;

            Console.WriteLine(b);
            int m = 1_000_000;
            int n = int.Parse(Console.ReadLine());

            double x = double.Parse(Console.ReadLine());

            double sum = x;

            for (int i = 1; i <= n; i++)
            {
                int p = i % 2 == 0 ? 1 : -1;
                sum += (-1) * p * (Math.Pow(x, 2 * i + 1) / (2 * i + 1));
            }

            Console.WriteLine(sum);

        }
    }
}
