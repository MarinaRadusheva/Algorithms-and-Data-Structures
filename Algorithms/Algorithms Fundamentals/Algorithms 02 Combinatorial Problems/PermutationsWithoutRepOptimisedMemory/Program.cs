using System;

namespace PermutationsWithoutRepOptimisedMemory
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
            if (index >= elements.Length-1)
            {
                Console.WriteLine(string.Join(" ", elements));
                return;
            }

            GetPermutations(index + 1);
            for (int i = index + 1; i < elements.Length; i++)
            {
                SwapElements(index, i);
                GetPermutations(index + 1);
                SwapElements(index, i);
            }
        }
        private static void SwapElements(int first, int second)
        {
            string temp = elements[first];
            elements[first] = elements[second];
            elements[second] = temp;
        }
    }
}
