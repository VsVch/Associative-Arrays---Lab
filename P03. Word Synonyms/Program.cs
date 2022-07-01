using System;
using System.Collections.Generic;

namespace P03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPairs = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> wordSynonims = new Dictionary<string, List<string>>();
            List<string>sin = new List<string>();
            string key = string.Empty;
            for (int i = 1; i <= numberOfPairs*2; i++)
            {
                string newWord = Console.ReadLine();
                if (i % 2 != 0)
                {
                    key = newWord;
                    if (!wordSynonims.ContainsKey(newWord))
                    {
                        wordSynonims.Add(newWord, new List<string>());
                    }
                }
                else
                {
                    wordSynonims[key].Add(newWord);
                }


            }
            foreach (var item in wordSynonims)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
