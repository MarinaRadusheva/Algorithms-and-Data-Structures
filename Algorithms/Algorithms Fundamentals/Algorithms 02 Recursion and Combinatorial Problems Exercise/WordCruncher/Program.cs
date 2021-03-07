using System;
using System.Collections.Generic;

namespace WordCruncher
{
    class Program
    {
        static Dictionary<int, List<string>> syllables;
        static Dictionary<string, int> syllableCount;
        static string target;
        static string result = "";
        static List<string> resultList;
        static HashSet<string> uniqueResults = new HashSet<string>();
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            syllables = new Dictionary<int, List<string>>();
            syllableCount = new Dictionary<string, int>();
            resultList = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                int len = input[i].Length;
                if (!syllables.ContainsKey(len))
                {
                    syllables.Add(len, new List<string>());
                }
                syllables[len].Add(input[i]);
                if (!syllableCount.ContainsKey(input[i]))
                {
                    syllableCount.Add(input[i], 0);
                }
                syllableCount[input[i]]++;
            }
            target = Console.ReadLine();
            FindSolutions(target.Length);
            foreach (var variation in uniqueResults)
            {
                Console.WriteLine(variation);
            }
        }

        private static void FindSolutions(int currentLen)
        {
            if (currentLen <= 0)
            {
                uniqueResults.Add(string.Join(" ", resultList));
                return;
            }
            foreach (var syllLength in syllables)
            {
                if (syllLength.Key > currentLen)
                {
                    continue;
                }
                for (int i = 0; i < syllLength.Value.Count; i++)
                {
                    string newSyllable = syllLength.Value[i];
                    if (syllableCount[newSyllable] == 0)
                    {
                        continue;
                    }
                    result += newSyllable;
                    syllableCount[newSyllable]--;
                    if (target.StartsWith(result))
                    {
                        resultList.Add(newSyllable);
                        
                        FindSolutions(target.Length - result.Length);
                        resultList.RemoveAt(resultList.Count - 1);
                        
                    }

                    result = result.Remove(result.Length - newSyllable.Length);
                    syllableCount[newSyllable]++;

                }
            }
        }
    }
}
