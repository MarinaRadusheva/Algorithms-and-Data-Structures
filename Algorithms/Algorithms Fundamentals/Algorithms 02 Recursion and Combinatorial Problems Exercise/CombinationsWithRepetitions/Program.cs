using System;

namespace CombinationsWithRepetitions
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
            GetAllCombinations(0,1);
        }

        private static void GetAllCombinations(int index, int start)
        {
            if (index >= combination.Length)
            {
                Console.WriteLine(string.Join(" ", combination));
                return;
            }
            for (int i=start; i<=n; i++)
            {
                combination[index] = i;
                GetAllCombinations(index + 1, i);
            }
        }
    }
}
