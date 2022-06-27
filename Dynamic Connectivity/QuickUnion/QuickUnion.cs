using System;
using System.Collections.Generic;
using System.Linq;

namespace Quick_Union
{
    public class QuickUnion
    {
        private IList<int> nodes;
        public QuickUnion(int number) => nodes = Enumerable.Range(0, number).ToList();
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
            // O(N)
            var notValidValue = Root(first);
            var targetValue = Root(second); 

            nodes[notValidValue] = targetValue;
        }
    }
}
