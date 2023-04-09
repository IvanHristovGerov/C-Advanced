using System;
using System.Linq;

namespace _001._ReadingFromConsoleShort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Четене за Judge вход

            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int [] rowData = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            PrintMatrix(matrix);
        }
        // Принтиране на матрица:
        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
