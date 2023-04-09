using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            input = input.OrderByDescending(x => x)
                .Take(3) //Takes first 3 or less!
                .ToList();

            Console.WriteLine(String.Join(" ", input));
        }
    }
}
