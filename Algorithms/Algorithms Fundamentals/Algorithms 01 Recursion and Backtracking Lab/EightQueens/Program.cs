using System;
using System.Collections.Generic;

namespace EightQueens
{
    class Program
    {
        private const int size = 8;
        private static HashSet<int> attackedRows = new HashSet<int>();
        private static HashSet<int> attackedCols = new HashSet<int>();
        private static HashSet<int> attackedRightDiagonals = new HashSet<int>();
        private static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
        static void Main(string[] args)
        {
            char[,] board = new char[size, size];
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = '-';
                }
            }
            PlaceQueens(board, 0);
        }
        public static void PlaceQueens(char[,] board, int row)
        {
            if (row==board.GetLength(0))
            {
                PrintBoard(board);
                return;
            }
            for (int col = 0; col < board.GetLength(1); col++)
            {
                if (NotAttacked(row, col))
                {
                    board[row, col] = '*';
                    attackedRows.Add(row);
                    attackedCols.Add(col);
                    attackedLeftDiagonals.Add(col - row);
                    attackedRightDiagonals.Add(col + row);
                    PlaceQueens(board, row + 1);
                    board[row, col] = '-';
                    attackedRows.Remove(row);
                    attackedCols.Remove(col);
                    attackedLeftDiagonals.Remove(col - row);
                    attackedRightDiagonals.Remove(col + row);
                }
              
             
            }
            
        }

        private static void PrintBoard(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static bool NotAttacked(int row, int col)
        {
            int leftDiagonal = (col -row);
            int rightDiagonal = (col + row);
            if (attackedRows.Contains(row))
            {
                return false;
            }
            if (attackedCols.Contains(col))
            {
                return false;
            }
            if (attackedLeftDiagonals.Contains(leftDiagonal)|| attackedRightDiagonals.Contains(rightDiagonal))
            {
                return false;
            }
            return true;
        }
    }
}
