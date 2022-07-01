using System;
using System.Linq;

namespace PP04._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("\n", Console.ReadLine().Split().Where(w => w.Length % 2 == 0).ToArray()));

        }
    }
}
