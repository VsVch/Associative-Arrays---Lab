using System;
using System.Linq;

namespace PPP04._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("\n", Console.ReadLine().Split().Where(x => x.Length % 2 == 0)));
        }
    }
}
