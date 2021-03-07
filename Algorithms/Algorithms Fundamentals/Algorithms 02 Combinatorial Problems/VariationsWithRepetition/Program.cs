using System;

namespace VariationsWithRepetition
{
    class Program
    {

        static string[] elements;
        static string[] variation;
        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            variation = new string[n];
            GetVariations(0);
        }

        private static void GetVariations(int index)
        {
            if (index >= variation.Length)
            {
                Console.WriteLine(string.Join(" ", variation));
                return;
            }
            for (int i = 0; i < elements.Length; i++)
            {
                    variation[index] = elements[i];
                    GetVariations(index + 1);
            }
        }

    }
}
