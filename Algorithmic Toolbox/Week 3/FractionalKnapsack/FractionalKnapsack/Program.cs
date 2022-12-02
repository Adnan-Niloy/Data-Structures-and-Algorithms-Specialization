using System;
using System.Collections.Generic;
using System.Linq;

namespace FractionalKnapsack
{
    internal class Program
    {
        static double GetOptimal(int capacity, List<Knapsack> sack)
        {
            sack = sack.OrderByDescending(c => c.Factor).ToList();
            double result = 0;
            var size = sack.Count;

            for (var i = 0; i < size; i++)
            {
                if (sack[i].Weight <= 0)
                    continue;

                if (sack[i].Weight <= capacity)
                {
                    result += sack[i].Cost;
                    capacity -= sack[i].Weight;
                }
                else
                {
                    result += (double)sack[i].Cost / sack[i].Weight * capacity;
                    capacity -= capacity;
                }

                if (capacity <= 0)
                    break;

            }

            return result;

        }

        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var tokens = input.Split(' ');
            var n = int.Parse(tokens[0]);
            var c = int.Parse(tokens[1]);

            var sack = new List<Knapsack>();

            for (var i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                var items = line.Split(' ');

                var item = new Knapsack
                {
                    Cost = int.Parse(items[0]),
                    Weight = int.Parse(items[1])
                };

                item.Factor = (double)item.Cost / item.Weight;

                sack.Add(item);
            }


            Console.WriteLine(GetOptimal(c, sack));

        }
    }

    public class Knapsack
    {
        public int Cost { get; set; }

        public int Weight { get; set; }

        public double Factor { get; set; }
    }
}
