using System;

namespace GCD
{
    internal class Program
    {
        static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        static void Main()
        {
            var input = Console.ReadLine();
            var tokens = input.Split(' ');
            var a = int.Parse(tokens[0]);
            var b = int.Parse(tokens[1]);

            Console.WriteLine(a > b ? GCD(a, b) : GCD(b, a));
        }
    }
}
