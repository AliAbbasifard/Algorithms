using System;
using System.Collections.Generic;
using System.Linq;

namespace Quick_Union
{
    public class QuickUnion
    {
        private IList<int> nodes;
        public QuickUnion(int number) => nodes = Enumerable.Range(0, number).ToList();
        public int Root(int nodeIndex)
        {
            while (!nodes[nodeIndex].Equals(nodeIndex))
                nodeIndex = nodes[nodeIndex];

            return nodeIndex;
        }
        public bool Connected(int first, int second) => Root(first).Equals(Root(second));
        public void Union(int first, int second)
        {
            var notValidValue = Root(first);
            var targetValue = Root(second);

            nodes[notValidValue] = targetValue;
        }
    }
}
