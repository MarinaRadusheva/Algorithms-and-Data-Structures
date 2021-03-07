using System;

namespace VariationsWithoutRepetitions
{
    class Program
    {
        static string[] elements;
        static string[] variation;
        static bool[] used;
        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            variation = new string[n];
            used = new bool[elements.Length];
            GetVariations(0);
        }

        private static void GetVariations(int index)
        {
            if (index>=variation.Length)
            {
                Console.WriteLine(string.Join(" ",variation));
                return;
            }
            for (int i = 0; i < elements.Length; i++)
            {
                if (!used[i])
                {
                    variation[index] = elements[i];
                    used[i] = true;
                    GetVariations(index + 1);
                    used[i] = false;
                }
            }
        }
    }
}
