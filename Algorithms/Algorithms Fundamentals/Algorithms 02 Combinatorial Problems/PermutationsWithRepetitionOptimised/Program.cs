using System;
using System.Collections.Generic;

namespace PermutationsWithRepetitionOptimised
{
    class Program
    {
        static string[] elements;
        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split();
            GetPermutations(0);
        }

        private static void GetPermutations(int index)
        {
            if (index>=elements.Length-1)
            {
                Console.WriteLine(string.Join(" ", elements));
                return;
            }
            GetPermutations(index + 1);
            HashSet<string> used = new HashSet<string> { elements[index] };
            for (int i = index+1; i < elements.Length; i++)
            {
                if (!used.Contains(elements[i]))
                {
                    SwapElements(index, i);
                    GetPermutations(index + 1);
                    SwapElements(index, i);
                    used.Add(elements[i]);
                }
            }
        }

        private static void SwapElements(int index, int i)
        {
            string temp = elements[index];
            elements[index] = elements[i];
            elements[i] = temp;
        }
    }
}
