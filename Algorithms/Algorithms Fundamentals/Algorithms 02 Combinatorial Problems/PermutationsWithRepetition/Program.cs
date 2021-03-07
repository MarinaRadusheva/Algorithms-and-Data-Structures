using System;
using System.Collections.Generic;

namespace PermutationsWithRepetition
{
    class Program
    {
        static HashSet<string> result = new HashSet<string>();
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split();
            bool[] usedElements = new bool[elements.Length];
            string[] permutation = new string[elements.Length];
            GetAllPermutations(elements, usedElements, permutation, 0);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static void GetAllPermutations(string[] elements, bool[] usedElements, string[] permutation, int index)
        {

            if (index == elements.Length)
            {
                result.Add(string.Join(" ", permutation));
                return;
            }
            for (int i = 0; i < usedElements.Length; i++)
            {
                if (!usedElements[i])
                {
                    usedElements[i] = true;
                    permutation[index] = elements[i];
                    GetAllPermutations(elements, usedElements, permutation, index + 1);
                    usedElements[i] = false;
                }
            }
        }
    }
}
