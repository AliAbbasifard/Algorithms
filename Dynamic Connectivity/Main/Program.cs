using MyOwnSolution;
using System;
using System.Collections.Generic;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            // create board
            ICollection<int> nodes = new List<int>();
            ICollection<(int, int, bool)> pathes = new List<(int, int, bool)>();

            int nodeNumber = 0;
            bool finishRelation = false;

            Console.WriteLine("First enter Nodes. -1 means end.");
            while (true)
            {
                Console.Write($"Node Number: {nodeNumber + 1} Value: ");
                int nodeValue = int.Parse(Console.ReadLine());

                if (nodeValue.Equals(-1))
                    break;

                nodes.Add(nodeValue);
                nodeNumber += 1;
            }

            Console.WriteLine("Now enter Relations.");
            while (finishRelation is false)
            {
                Console.Write("From: ");
                int from = int.Parse(Console.ReadLine());
                if (nodes.Contains(from) is false)
                    break;

                Console.Write("To: ");
                int to = int.Parse(Console.ReadLine());
                if (nodes.Contains(to) is false)
                    break;

                pathes.Add((from, to, false));

                Console.Write("Finished? ");
                finishRelation = Console.ReadLine().ToLower().Equals("y") ? true : false;
            }

            // call core algorithm method
            var result = Solution1.Solve(nodes, pathes, int.Parse(args[0]), int.Parse(args[1]));

            Console.WriteLine(result);
        }
    }
}
