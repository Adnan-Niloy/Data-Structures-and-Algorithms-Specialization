using System;

namespace MoneyChange
{
    internal class Program
    {
        private static int Change(int m)
        {
            var result = 0;

            while (m > 0)
            {
                if (m >= 10)
                    m -= 10;
                else if (m >= 5)
                    m -= 5;
                else
                    m -= 1;

                result++;
            }

            return result;
        }

        static void Main()
        {
            var input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Change(input));
        }
    }
}
