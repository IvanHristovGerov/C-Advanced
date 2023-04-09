using System;

namespace _00._Reading_Matrixes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Четене на ред по ред и колона по колона:

            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(Console.ReadLine()); 
                }
            }

            //Така я печатаме:

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
            }




        }


       

    }
}
