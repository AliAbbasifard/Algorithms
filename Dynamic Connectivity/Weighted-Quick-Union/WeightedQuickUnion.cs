using System;
using System.Collections.Generic;
using System.Linq;

namespace Weighted_Quick_Union
{
    public class WeightedQuickUnion
    {
        private IList<int> nodes;
        private IList<int> treeLength;
        public WeightedQuickUnion(int number)
        {
            nodes = Enumerable.Range(0, number).ToList();
            treeLength = Enumerable.Repeat(1, number).ToList();
        }
        public int Root(int node)
        {
            // a node is root when nodes[node].Equal(node)
            while (!nodes[node].Equals(node))
                node = nodes[node];

            return node;
        }
        public bool Connected(int first, int second) => Root(first).Equals(Root(second)); // O(N)
        public void Union(int first, int second)
        {
            // find smaller tree
            var smaller = (treeLength[Root(first)] < treeLength[Root(second)]) ? first : second;
            var bigger = (first.Equals(smaller)) ? second : first;

            var notValidValue = Root(smaller);
            var targetValue = Root(bigger);

            treeLength[targetValue] += treeLength[notValidValue];

            nodes[notValidValue] = targetValue;
        }
    }
}
