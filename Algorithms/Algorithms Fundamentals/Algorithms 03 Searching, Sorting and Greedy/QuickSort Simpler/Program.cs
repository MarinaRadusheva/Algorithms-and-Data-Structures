using System;
using System.Linq;

namespace QuickSort_Simpler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            QuickSort(elements, 0, elements.Length - 1);
            Console.WriteLine(string.Join(" ", elements));
        }
        // 5 8 6 3 4 12 2 9
        //5 3 4 2 6 12 8 9
        private static void QuickSort(int[] elements, int leftIdx, int rightIdx)
        {
            if (leftIdx >= rightIdx)
            {
                return;
            }
            int pivot = elements[leftIdx];
            int storeIdx = leftIdx + 1;
            for (int i = storeIdx; i <= rightIdx; i++)
            {
                if (elements[i] < pivot)
                {
                    Swap(elements, i, storeIdx);
                    storeIdx++;
                }

            }
            Swap(elements, leftIdx, storeIdx - 1);
            QuickSort(elements, leftIdx, storeIdx - 1);
            QuickSort(elements, storeIdx, rightIdx);
        }

        private static void Swap(int[] elements, int leftIdx, int rightIdx)
        {
            int temp = elements[leftIdx];
            elements[leftIdx] = elements[rightIdx];
            elements[rightIdx] = temp;
        }
    }
}
