using System;
using System.IO;




namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"../../../input.txt";
            string outputFilePath = @"../../../output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader("../../../input.txt"))
            {
                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    string line = "";
                    int row = 0;
                    while (line != null)
                    {
                        line = reader.ReadLine();
                        if (row % 2 == 1)
                        {
                            writer.WriteLine(line);

                        }
                        row++;
                    }

                }
            }
        }
    }
}
