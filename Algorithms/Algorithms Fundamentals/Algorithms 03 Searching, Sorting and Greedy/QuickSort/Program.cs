using System;
using System.Linq;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            QuickSort(elements, 0, elements.Length - 1);
            Console.WriteLine(string.Join(" ", elements));

        }

        private static void QuickSort(int[] elements, int lowIndx, int highIndx)
        {
            if (lowIndx<highIndx)
            {
                int partition = Partition(elements, lowIndx, highIndx);
                QuickSort(elements, lowIndx, partition - 1);
                QuickSort(elements, partition + 1, highIndx);
            }
        }

        private static int Partition(int[] elements, int lowIndx, int highIndx)
        {
            int i = lowIndx - 1;
            int pivot = elements[highIndx];
            for (int j = lowIndx; j <highIndx; j++)
            {
                if (elements[j]<pivot)
                {
                    i++;
                    SwapElements(elements, i, j);
                }
            }
            SwapElements(elements,i + 1, highIndx);
            return i + 1;
        }

        private static void SwapElements(int[] elements, int i, int j)
        {
            int temp = elements[i];
            elements[i] = elements[j];
            elements[j] = temp;
        }
    }
}
