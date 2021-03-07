using System;
using System.Collections.Generic;
using System.Linq;

namespace AreasInMatrix
{
    class Program
    {
        static char[,] matrix;
        static List<Area> areas;
        static bool[,] visited;
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            matrix = NewMatrix(rows, cols);
            visited = new bool[rows, cols];
            areas = new List<Area>();
            for (int  row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col]=='*')
                    {
                        continue;
                    }
                    if (visited[row,col])
                    {
                        continue;
                    }
                    Area nextArea = new Area { Row = row, Col = col };
                    nextArea.Size = GetArea(row, col);
                    areas.Add(nextArea);
                }
            }
            var sortedAreas = areas.OrderByDescending(x => x.Size).ThenBy(x => x.Row).ThenBy(x => x.Col).ToList();
            Console.WriteLine($"Total areas found: { areas.Count}");
            for (int i = 0; i < sortedAreas.Count; i++)
            {
                Console.WriteLine($"Area #{i+1} at ({sortedAreas[i].Row}, {sortedAreas[i].Col}), size: {sortedAreas[i].Size}");
            }
        }

        private static int GetArea(int row, int col)
        {
            if (IsOutside(row,col))
            {
                return 0;
            }
            if (matrix[row,col]=='*')
            {
                return 0;
            }
            if (visited[row,col])
            {
                return 0;
            }
            visited[row, col] = true;
            return 1 + GetArea(row, col + 1) +
                GetArea(row + 1, col) +
                GetArea(row, col - 1) +
                GetArea(row - 1, col);

        }

        private static bool IsOutside(int row, int col)
        {
            return (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1));
        }

        private static char[,] NewMatrix(int rows, int cols)
        {
            var mtrx = new char[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < cols; j++)
                {
                    mtrx[i, j] = line[j];
                }
            }
            return mtrx;
        }
    }
    class Area
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public int Size { get; set; }
    }
}
