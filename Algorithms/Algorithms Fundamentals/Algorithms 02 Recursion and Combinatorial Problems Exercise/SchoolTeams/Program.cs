using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolTeams
{
    class Program
    {
        static List<string> boysCombinations = new List<string>();
        static List<string> girlsCombinations = new List<string>();
        static string[] girlCombination = new string[3];
        static string[] boyCombination = new string[2];
        static void Main(string[] args)
        {
            List<string> girls = Console.ReadLine().Split(", ").ToList();
            List<string> boys = Console.ReadLine().Split(", ").ToList();
            GetAllCombinations(girls, girlCombination, girlsCombinations, 0, 0);
            GetAllCombinations(boys, boyCombination, boysCombinations, 0, 0);
            PrintAllCombinations();
        }

        private static void PrintAllCombinations()
        {
            for (int i = 0; i < girlsCombinations.Count; i++)
            {
                for (int j = 0; j < boysCombinations.Count; j++)
                {
                    Console.WriteLine(girlsCombinations[i] + ", " + boysCombinations[j]);
                }
            }
        }

        private static void GetAllCombinations(List<string> names, string[] combination, List<string> allresults, int index, int start)
        {
            if (index== combination.Length)
            {
                allresults.Add(string.Join(", ", combination));
                return;
            }
            for (int i = start; i < names.Count; i++)
            {
                combination[index] = names[i];
                GetAllCombinations(names, combination, allresults, index + 1, i + 1);
            }
        }
    }
}
