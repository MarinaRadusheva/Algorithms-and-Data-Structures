using System;

namespace CombinationsWithoutRepetitions
{
    class Program
    {
        static int[] combination;
        static int n;
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            combination = new int[k];
            GetCombinations(0, 1);
        }

        private static void GetCombinations(int index, int start)
        {
            if (index>=combination.Length)
            {
                Console.WriteLine(string.Join(" ", combination));
                return;
            }
            for (int i = start; i <=n; i++)
            {
                combination[index] = i;
                GetCombinations(index + 1, i + 1);
            }
        }
    }
}
