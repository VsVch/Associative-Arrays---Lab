using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            SortedDictionary<int, int> countsNumber = new SortedDictionary<int, int>();
            foreach (var nums in input)
            {
                int number = int.Parse(nums);
                if (countsNumber.ContainsKey(number))
                {
                    countsNumber[number]++;

                }
                else
                {
                    countsNumber[number] = 1;
                }

            }
            foreach (var numberCounters in countsNumber.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{numberCounters.Key} -> {numberCounters.Value}");
            }


        }
    }
}
