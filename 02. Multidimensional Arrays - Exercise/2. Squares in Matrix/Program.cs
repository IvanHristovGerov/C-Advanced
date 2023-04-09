using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            if (input.Length < 2)
            {
                Console.WriteLine(0);
            }

            else
            {
                int rows = input[0];
;               int cols = input[1];

                var matrix = new char[rows][];

                for (int row = 0; row < rows; row++)
                {
                    matrix[row] = Console.ReadLine()
                        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                        .Select(char.Parse)
                        .ToArray();
                }
                int counter = 0;

                for (int row = 0; row < rows -1; row++)
                {
                    for (int col = 0; col  < cols -1; col ++)
                    {
                        if (matrix[row][col] == matrix[row][col + 1] && 
                            matrix[row][col] == matrix[row + 1][col] &&
                            matrix[row][col] == matrix[row + 1][col + 1])
                        {
                            counter++;
                        }
                    }
                   
                }
                Console.WriteLine(counter);
            }
            
        }
    }
}
