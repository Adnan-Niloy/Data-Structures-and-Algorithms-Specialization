using System;

namespace FibonacciHuge
{
    internal class Program
    {
        private static long Fibonacci(long n, long m)
        {
            if (n <= 1)
                return n;

            long a = 0;
            long b = 1;

            for (var i = 2; i <= n; i++)
            {
                var c = b;
                b = (a + b) % m;
                a = c;
            }

            return b % m;
        }

        private static long PisanoPeriod(long m)
        {
            long prev = 0;
            long curr = 1;
            long res = 0;

            for (long i = 0; i < m * m; i++)
            {
                var temp = curr;
                curr = (prev + curr) % m;
                prev = temp;

                if (prev == 0 && curr == 1)
                    res = i + 1;
            }

            return res;
        }

        private static long FibonacciMod(long n, long m)
        {
            var pisanoPeriod = PisanoPeriod(m);
            n %= pisanoPeriod;
            return Fibonacci(n, m);
        }

        static void Main()
        {
            var input = Console.ReadLine();
            var tokens = input.Split(' ');
            var a = Convert.ToInt64(tokens[0]);
            var b = Convert.ToInt64(tokens[1]);

            Console.WriteLine(FibonacciMod(a, b));
        }
    }
}
