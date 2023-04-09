using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Stack<int> stack = new Stack<int>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmdArgs = command
                    .Split();

                if (cmdArgs[0] == "add")
                {
                    int first = int.Parse(cmdArgs[1]);
                    int second = int.Parse(cmdArgs[2]);

                    stack.Push(first);
                    stack.Push(second);
                }
                if (cmdArgs[0] == "remove")
                {
                    int n = int.Parse(cmdArgs[1]);

                    if (n < stack.Count)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            stack.Pop();
                        }
                    }
                    

                    
                }
                command = Console.ReadLine().ToLower();
            }

            Console.WriteLine(stack.Sum());

            Console.WriteLine(String.Join(" ", stack));
        }
    }
}
