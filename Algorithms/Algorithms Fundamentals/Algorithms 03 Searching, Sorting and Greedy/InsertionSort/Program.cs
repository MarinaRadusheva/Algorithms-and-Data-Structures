using System;
using System.Linq;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SelectionSort(elements);
            Console.WriteLine(string.Join(" ", elements));
        }

        private static void SelectionSort(int[] elements)
        {
            for (int i = 1; i < elements.Length; i++)
            {
                int value = elements[i];
                int index = i;
                while (index>0 && value<elements[index-1])
                {
                    elements[index] = elements[index - 1];
                    index--;
                }
                elements[index] = value;
            }
        }
    }
}
