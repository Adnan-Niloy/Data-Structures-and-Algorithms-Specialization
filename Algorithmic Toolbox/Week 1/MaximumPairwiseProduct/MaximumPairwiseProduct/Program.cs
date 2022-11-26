using System;
using System.Linq;

namespace MaximumPairwiseProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var input = Console.ReadLine();

            var numbers = input.Split(' ').Select(c => Convert.ToInt32(c)).ToArray();

            Console.WriteLine(MaximumPairwiseProduct(n, numbers));
        }

        private static long MaximumPairwiseProduct(int size, int[] numbers)
        {
            Array.Sort(numbers);

            var result = (long)numbers[size - 1] * numbers[size - 2];

            return result;
        }
    }
}
