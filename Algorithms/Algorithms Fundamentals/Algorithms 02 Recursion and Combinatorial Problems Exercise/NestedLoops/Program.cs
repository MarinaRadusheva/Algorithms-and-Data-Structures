using System;

namespace NestedLoops
{
    class Program
    {
        static int[] elements;
        static int n;
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            elements = new int[n];
            RecursiveLoops(0);
        }

        private static void RecursiveLoops(int index)
        {
            if (index==n)
            {
                Console.WriteLine(string.Join(" ", elements));
                return;
            }
            
            for (int i = 1; i <=n; i++)
            {
                elements[index] = i;
                RecursiveLoops(index + 1);
            }
        }
    }
}
