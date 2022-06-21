using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnSolution
{
    public class Solution1
    {
        public static bool Solve(IEnumerable<int> nodes, IEnumerable<(int, int, bool)> pathes, int start, int end)
        {
            var pathStack = new Stack<(int, int, bool)>();

            // if start or end not in nodes, return false
            if ((!nodes.Contains(start)) || (!nodes.Contains(end)))
                return false;

            if (start.Equals(end))
                return true;

            // if start != end and there is no path in board
            if (pathes.Count().Equals(0))
                return false;

            var current = start;

            while (!current.Equals(end))
            {
                // find available path from current node
                var availablePath = pathes.Where(path => (path.Item1.Equals(start) || path.Item2.Equals(start)) && path.Item3.Equals(false));
                
                foreach (var path in availablePath)
                    pathStack.Push(path);

                if (!availablePath.Any() && !pathStack.Any())
                    return false;

                var choosenPath = pathStack.Pop();

                var next = choosenPath.Item1.Equals(current) ? choosenPath.Item2 : choosenPath.Item1;

                current = next;
            }

            return true;
        }
    }
}
