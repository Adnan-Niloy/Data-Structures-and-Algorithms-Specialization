using System;
namespace FibonacciLastDigit
{
    internal static class Program
    {
        private static int Fibonacci(int n)
        {
            if (n <= 1)
                return n % 10;

            long a = 0;
            long b = 1;

            for (var i = 2; i <= n; i++)
            {
                var c = a + b;
                a = b;
                b = c;
            }

            return (int)(b % 10);
        }

        private static int FibonacciLastDigit(int n)
        {
            var number = n % 60;
            return Fibonacci(number);
        }

        private static void Main()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FibonacciLastDigit(n));
        }
    }
}
