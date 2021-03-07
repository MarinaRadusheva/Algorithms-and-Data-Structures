using System;
using System.Linq;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            BubbleSort(elements);
            Console.WriteLine(string.Join(" ", elements));
        }

        private static void BubbleSort(int[] elements)
        {
            int len = elements.Length;
            for(int n = 0; n<elements.Length; n++)
            {
                for (int i = 0; i < len - 1; i++)
                {
                    if (elements[i] > elements[i + 1])
                    {
                        int temp = elements[i];
                        elements[i] = elements[i + 1];
                        elements[i + 1] = temp;
                    }
                }
                len--;
            }
            
        }
    }
}
