using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string, List<decimal>> studentGrades = 
                new Dictionary<string, List<decimal>>();

            int n = int.Parse(Console.ReadLine());

            //Pesho 2
            //Pesho 3
            //Pesho 4

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string studentName = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!studentGrades.ContainsKey(studentName))
                {
                    studentGrades.Add(studentName, new List<decimal>());
                }

                studentGrades[studentName].Add(grade);

               
            }
            foreach (var studentGrade in studentGrades)
            {
                Console.WriteLine($"{studentGrade.Key} -> {string.Join(" ",
                    studentGrade.Value)} (avg: {studentGrade.Value.Average():f2})");
            }
        }
    }
}
