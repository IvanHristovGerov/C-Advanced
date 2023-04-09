using System;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = row + col;
                }
            }
            PrintMatrix(matrix);

            for (int i = 0; i < rows; i++)
            {
                Console.Write(matrix[i,i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < rows; i++)
            {
                Console.Write(matrix[rows - i - 1, i] + " ");
            }
           
            //Find the sum of all of 2 diagonals:


        }




        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] < 10)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }


   
}
