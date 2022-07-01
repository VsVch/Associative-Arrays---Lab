using System;
using System.Linq;

namespace P04._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Where(w => w.Length % 2 == 0).ToArray();
            string[] newString = input.Where(w => w.Length % 2 == 0).ToArray();
            foreach (var item in newString)
            {
                Console.WriteLine($"{item}");
            }
            
        }
    }
}
