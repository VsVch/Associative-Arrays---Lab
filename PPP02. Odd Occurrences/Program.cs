using System;
using System.Collections.Generic;
using System.Linq;

namespace PPP02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().ToLower().Split();
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (var input in inputs)
            {
                if (counts.ContainsKey(input))
                {
                    counts[input]++;
                }
                else
                {
                    counts.Add(input, 1);
                }

            }
            foreach (var count in counts.Where(w => w.Value % 2 != 0))
            {
                Console.Write($"{count.Key} ");
            }
        }
    }
}
