using System;
using System.Collections.Generic;

namespace FindAllPaths
{
    class Program
    {
        static List<char> path = new List<char>();
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            char[,] field = new char[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < cols; j++)
                {
                    field[i, j] = line[j];
                }
            }
            FindAllPathsToEnd(field, 0, 0, '\0');
        }

        private static void FindAllPathsToEnd(char[,] field, int row, int col, char c)
        {
           
            if (!CanMove(field, row, col))
            {
                return;
            }
            path.Add(c);
            if (field[row, col] == 'e')
            {
                Console.WriteLine(string.Join("", path));
                path.RemoveAt(path.Count - 1);
                return;
            }
            else
            {
                field[row, col] = 'v';
                FindAllPathsToEnd(field, row, col + 1, 'R');
                
                FindAllPathsToEnd(field, row + 1, col, 'D');
               
                FindAllPathsToEnd(field, row, col - 1, 'L');
                
                FindAllPathsToEnd(field, row - 1, col, 'U');
                field[row, col] = '-';
                path.RemoveAt(path.Count - 1);
            }



        }

        private static bool CanMove(char[,] field, int row, int col)
        {
            if (row < 0 || col < 0 || row > field.GetLength(0) - 1 || col > field.GetLength(1) - 1 || field[row, col] == 'v' || field[row, col] == '*')
            {
                return false;
            }
            return true;
        }
    }
}
