using System;

namespace Generating01Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            GenerateVectors(array, 0);
        }

        private static void GenerateVectors(int[] arr, int index)
        {
            if (index==arr.Length)
            {
                Console.WriteLine(string.Join("", arr));
                return;
            }
            
            for (int i = 0; i <=1; i ++)
            {

                arr[index] = i;
                GenerateVectors(arr, index + 1);                
            }
            
        }
    }
}
