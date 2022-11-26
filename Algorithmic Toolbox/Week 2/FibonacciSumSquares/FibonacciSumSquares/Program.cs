using System;

namespace FibonacciSumSquares
{
    internal static class Program
    {
        private static long Fibonacci(long n)
        {
            if (n % 60 <= 1)
                return n % 60;

            long a = 0;
            long b = 1;
            long result = 1;

            for (var i = 2; i <= n % 60; i++)
            {
                var c = a + b;
                a = b;
                b = c;

                var sum = (c % 10 * c % 10) % 10;
                result += sum;
                result %= 10;
            }

            return result;
        }


        static void Main()
        {
            var input = Console.ReadLine();
            var a = Convert.ToInt64(input);

            Console.WriteLine(Fibonacci(a));
        }
    }
}
