using MyOwnSolution;
using Quick_Find;
using System;
using System.Collections.Generic;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyOwnSolution
            // create board
            //ICollection<int> nodes = new List<int>();
            //ICollection<(int, int, bool)> pathes = new List<(int, int, bool)>();

            //int nodeNumber = 0;
            //bool finishRelation = false;

            //Console.WriteLine("First enter Nodes. -1 means end.");
            //while (true)
            //{
            //    Console.Write($"Node Number: {nodeNumber + 1} Value: ");
            //    int nodeValue = int.Parse(Console.ReadLine());

            //    if (nodeValue.Equals(-1))
            //        break;

            //    nodes.Add(nodeValue);
            //    nodeNumber += 1;
            //}

            //Console.WriteLine("Now enter Relations.");
            //while (finishRelation is false)
            //{
            //    Console.Write("From: ");
            //    int from = int.Parse(Console.ReadLine());
            //    if (nodes.Contains(from) is false)
            //        break;

            //    Console.Write("To: ");
            //    int to = int.Parse(Console.ReadLine());
            //    if (nodes.Contains(to) is false)
            //        break;

            //    pathes.Add((from, to, false));

            //    Console.Write("Finished? ");
            //    finishRelation = Console.ReadLine().ToLower().Equals("y") ? true : false;
            //}

            //call core algorithm method
            //var result = Solution1.Solve(nodes, pathes, int.Parse(args[0]), int.Parse(args[1]));

            //Console.WriteLine(result);
            #endregion

            #region QuickFind
            //Console.Write("Number of nodes: ");
            //var number = int.Parse(Console.ReadLine());

            //if (number > 0)
            //{
            //    var finished = false;
            //    QuickFind quickFind = new QuickFind(number);

            //    while (!finished)
            //    {
            //        Console.Write("Enter first node: ");
            //        int firstNode = int.Parse(Console.ReadLine());
            //        Console.Write("Enter second node: ");
            //        int secondNode = int.Parse(Console.ReadLine());

            //        if (!quickFind.Connected(firstNode, secondNode))
            //            quickFind.Union(firstNode, secondNode);

            //        Console.Write("finished? y if Yes.");
            //        finished = Console.ReadLine().ToLower().Equals("y") ? true : false;
            //    }

            //    Console.WriteLine("Now Insert Two Value to check if are Connected or Not!");
            //    Console.Write("First: ");
            //    var first = int.Parse(Console.ReadLine());
            //    Console.Write("Second:");
            //    var second = int.Parse(Console.ReadLine());

            //    var result = quickFind.Connected(first, second);

            //    Console.WriteLine(result);
            //}
            //else
            //    Console.WriteLine("number of nodes should be positive number");
            #endregion
        }
    }
}
