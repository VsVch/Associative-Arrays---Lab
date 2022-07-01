using System;
using System.Collections.Generic;

namespace PP03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPairs = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> wordAndSynonums = new Dictionary<string, List<string>>();
            List<string> sin = new List<string>();
            string key = string.Empty;
            for (int i = 1; i <= numberOfPairs * 2; i++)
            {
                string currentWord = Console.ReadLine();
                if (i % 2 != 0)
                {
                    key = currentWord;
                    if (!wordAndSynonums.ContainsKey(currentWord))
                    {
                        wordAndSynonums.Add(currentWord, new List<string>());
                    }

                }
                else
                {
                    wordAndSynonums[key].Add(currentWord);
                }

            }
            foreach (var item in wordAndSynonums)
            {
                Console.WriteLine($"{item.Key} - {(string.Join(" ", item.Value))}");
            }
        }
    }
}
