using System;
using System.Collections.Generic;

namespace CombinationsWithoutRepetition
{
    class Program
    {
        static string[] elements;
        static string[] combination;
        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            combination = new string[n];
            GetAllCombinations(0,0);
        }

        private static void GetAllCombinations(int index, int start)
        {
            if (index>=combination.Length)
            {
                Console.WriteLine(string.Join(" ", combination));
                return;
            }
            
            for (int i = start; i < elements.Length; i++)
            {
                combination[index] = elements[i];
                GetAllCombinations(index + 1, i + 1);
            }
        }
    }
}
