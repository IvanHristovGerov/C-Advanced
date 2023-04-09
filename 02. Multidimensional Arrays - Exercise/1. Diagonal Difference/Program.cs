using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = rows;

            int[,] matrix = new int[rows, cols];

            int sumPrimary = 0;
            int sumSecondary = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();


                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            
            for (int i = 0; i < rows; i++)
            {
              

                sumPrimary += matrix[i, i];
                
            }

            for (int i = 0; i < rows; i++)
            {
               
                sumSecondary += matrix[rows - i - 1, i];

            }
            int totalSum = (sumPrimary - sumSecondary);

            Console.WriteLine(Math.Abs(totalSum));









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
