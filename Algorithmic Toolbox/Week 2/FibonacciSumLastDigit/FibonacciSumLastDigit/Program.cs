using System;

namespace FibonacciSumLastDigit
{
    internal static class Program
    {
        private static long Fibonacci(long n)
        {
            if (n <= 1)
                return n;

            var lastDigits = new int[60];
            lastDigits[0] = 0;
            lastDigits[1] = 1;

            long a = 0;
            long b = 1;
            long result = 1;

            for (var i = 2; i < 60; i++)
            {
                var c = a + b;
                a = b;
                b = c;
                result += c;

                lastDigits[i] = (int)(result % 10);
            }

            return lastDigits[n % 60];
        }


        static void Main()
        {
            var input = Console.ReadLine();
            var tokens = input.Split(' ');
            var a = Convert.ToInt64(tokens[0]);

            Console.WriteLine(Fibonacci(a));
        }
    }
}
