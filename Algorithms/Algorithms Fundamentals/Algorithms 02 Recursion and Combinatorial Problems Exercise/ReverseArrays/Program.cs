using System;

namespace ReverseArrays
{
    class Program
    {
        static string[] array;
        static void Main(string[] args)
        {
            array = Console.ReadLine().Split();
            ReverseArray(0, array.Length - 1);
            Console.WriteLine(string.Join(" ", array));
        }
        private static void ReverseArray(int indexStart, int indexEnd)
        {
            if (indexStart>=indexEnd)
            {
                return;
            }
            else
            {
                ReverseArray(indexStart + 1, indexEnd - 1);
                string temp = array[indexEnd];
                array[indexEnd] = array[indexStart];
                array[indexStart] = temp;
            }
        }
    }
}
