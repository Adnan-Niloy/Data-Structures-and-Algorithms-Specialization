using System;

namespace FibonacciPartialSum
{
    internal static class Program
    {
        private static int Fibonacci(long m, long n)
        {
            if (n <= 1)
                return (int)n;

            var lastDigits = new int[60];
            lastDigits[0] = 0;
            lastDigits[1] = 1;

            long a = 0;
            long b = 1;

            for (var i = 2; i < 60; i++)
            {
                var c = a + b;
                a = b;
                b = c;

                lastDigits[i] = (int)(c % 10);
            }

            var modM = m % 60;
            var modN = n % 60;
            var sum = 0;

            if (modM <= modN)
            {
                for (var i = modM; i <= modN; i++)
                    sum += lastDigits[i];
            }
            else
            {
                for (var i = modM; i < 60; i++)
                    sum += lastDigits[i];

                for (var i = 0; i <= modN; i++)
                    sum += lastDigits[i];
            }

            return sum % 10;
        }


        static void Main()
        {
            var input = Console.ReadLine();
            var tokens = input.Split(' ');
            var m = Convert.ToInt64(tokens[0]);
            var n = Convert.ToInt64(tokens[1]);

            Console.WriteLine(Fibonacci(m, n));
        }
    }
}
