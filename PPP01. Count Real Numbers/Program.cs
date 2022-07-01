using System;
using System.Collections.Generic;
using System.Linq;

namespace PPP01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            SortedDictionary<int, int> counts = new SortedDictionary<int, int>();

            foreach (var number in numbers)
            {
                int currentNumber = int.Parse(number);
                if (counts.ContainsKey(currentNumber))
                {
                    counts[currentNumber]++;
                }
                else
                {
                    counts[currentNumber] = 1;
                }

            }
            foreach (var count in counts)
            {
                Console.WriteLine($"{count.Key} -> {count.Value}");
            }

        }
    }
}
