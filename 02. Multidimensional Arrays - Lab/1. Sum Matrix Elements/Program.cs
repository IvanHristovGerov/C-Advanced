using System;
using System.Linq;


namespace _1._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //How do we read matrix from the console when we define row by row

           //
           // int rows = int.Parse(Console.ReadLine());
           // int cols = int.Parse(Console.ReadLine());
           //
           // int[,] matrix = new int [rows, cols];
           //
           // for (int row = 0; row < rows; row++)
           // {
           //     for (int col = 0; col < cols; col++)
           //     {
           //         matrix[row, col] = int.Parse(Console.ReadLine());
           //     }
           // }



            //How we read for judge:

            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            PrintMatrix(matrix)

        }
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
