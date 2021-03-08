using System;
using System.Linq;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sorted = MergeSort(elements);
            Console.WriteLine(string.Join(" ", sorted));
        }
        //5 8 9 2 11 3
        //
        private static int[] MergeSort(int[] elements)
        {
            if (elements.Length==1)
            {
                return elements;
            }
            int[] leftArray = elements.Take(elements.Length / 2).ToArray();
            int[] rightArray = elements.Skip(elements.Length / 2).ToArray();
            return MergeArrays(MergeSort(leftArray), MergeSort(rightArray));
            
        }

        private static int[] MergeArrays(int[] leftArray, int[] rightArray)
        {
            int[] mergedArray = new int[leftArray.Length + rightArray.Length];
            int sortedIdx = 0;
            int leftIdx = 0;
            int rightIdx = 0;
            while (leftIdx<leftArray.Length&&rightIdx<rightArray.Length)
            {
                if (leftArray[leftIdx]<rightArray[rightIdx])
                {
                    mergedArray[sortedIdx++] = leftArray[leftIdx++];
                }
                else
                {
                    mergedArray[sortedIdx++] = rightArray[rightIdx++];
                }
                
            }
            while (leftIdx<leftArray.Length)
            {
                mergedArray[sortedIdx++] = leftArray[leftIdx++];
            }
            while (rightIdx<rightArray.Length)
            {
                mergedArray[sortedIdx++] = rightArray[rightIdx++];
            }
            return mergedArray;
        }
    }
}
