using System;
using System.Collections.Generic;
using System.Linq;

namespace PP01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputDigit = Console.ReadLine().Split();
            SortedDictionary<int, int> numbersCount = new SortedDictionary<int, int>();
            foreach (var digit in inputDigit)
            {
                int realNumber = int.Parse(digit);
                if (numbersCount.ContainsKey(realNumber))
                {
                    numbersCount[realNumber]++;

                }
                else
                {
                    numbersCount[realNumber] = 1;
                }

            }
            foreach (var num in numbersCount.Keys)
            {
                Console.WriteLine($"{num} -> {numbersCount[num]}");
            }
 






        }
    }
}
