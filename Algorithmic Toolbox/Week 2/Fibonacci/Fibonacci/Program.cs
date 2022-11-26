using System;

namespace Fibonacci
{
    internal class Program
    {
        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            var a = 0;
            var b = 1;

            for (var i = 2; i <= n; i++)
            {
                var c = a + b;
                a = b;
                b = c;
            }

            return b;
        }

        static decimal FibonacciBig(int n)
        {
            if (n <= 1)
                return n;

            decimal a = 0;
            decimal b = 1;

            for (var i = 2; i <= n; i++)
            {
                var c = a + b;
                a = b;
                b = c;
            }

            return b;
        }


        static void Main()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FibonacciBig(n));
        }
    }
}
