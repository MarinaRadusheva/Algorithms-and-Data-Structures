using System;

namespace PascalsTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(PossibleCombinationsCount(n, k));
        }

        private static int PossibleCombinationsCount(int n, int k)
        {
            if ((k<1)||(k==n))
            {
                return 1;
            }
            return PossibleCombinationsCount(n-1,k) + PossibleCombinationsCount(n-1,k - 1);
        }
    }
}
