using System;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int wanted = int.Parse(Console.ReadLine());
            Console.WriteLine(FindIndex(elements, wanted));
        }

        private static int FindIndex(int[] elements, int wanted)
        {
            int left = 0;
            int right = elements.Length - 1;
            while (left<=right)
            {
                int mid = left + (right - left) / 2;
                if (elements[mid]==wanted)
                {
                    return mid;
                }
                else if (elements[mid]>wanted)
                {
                    right = mid-1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
    }
}
