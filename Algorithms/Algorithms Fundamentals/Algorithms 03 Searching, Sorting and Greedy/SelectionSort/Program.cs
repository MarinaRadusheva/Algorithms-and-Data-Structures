using System;
using System.Linq;

namespace SelectionSort
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
            int min;
            
            for (int i = 0; i < elements.Length; i++)
            {
                min = i;

                for (int j = i+1; j < elements.Length; j++)
                {
                    if (elements[j]<=elements[min])
                    {
                        min = j;
                        
                    }
                }
                if (min!=i)
                {
                    int temp = elements[i];
                    elements[i] = elements[min];
                    elements[min] = temp;
                }
                
            }
        }
    }
}
