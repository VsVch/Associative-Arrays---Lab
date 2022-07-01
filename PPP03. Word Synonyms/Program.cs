using System;
using System.Collections.Generic;

namespace PPP03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPairs = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> wordWithSynonyms = new Dictionary<string, List<string>>();
            string key = string.Empty;
            for (int i = 1; i <= numberOfPairs * 2 ; i++)
            {
                string currWord = Console.ReadLine();
                if (i % 2 != 0)
                {
                    key = currWord;
                    if (!wordWithSynonyms.ContainsKey(currWord))
                    {
                        wordWithSynonyms.Add(currWord, new List<string>());
                    }

                }
                else
                {
                    wordWithSynonyms[key].Add(currWord);
                }

            }
            foreach (var wordWithSynonym in wordWithSynonyms)
            {
                Console.WriteLine($"{wordWithSynonym.Key} - {(string.Join(", ", wordWithSynonym.Value))}");
            }
        }
    }
}
