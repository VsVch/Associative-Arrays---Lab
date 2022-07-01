using System;
using System.Collections.Generic;

namespace PP02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split();
            Dictionary<string, int> counts = new Dictionary<string, int>();
            List<string> wordOddTimes = new List<string>();
            foreach (var word in input)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;

                }
                else
                {
                    counts.Add(word, 1);
                }
            }

                foreach (var pair in counts)
                {
                    if (pair.Value % 2 != 0)
                    {
                        wordOddTimes.Add(pair.Key);
                    }
                }
                Console.WriteLine(string.Join(" ", wordOddTimes));
            
            
        }
    }
}
