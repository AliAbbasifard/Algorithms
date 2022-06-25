using System;
using System.Collections.Generic;
using System.Linq;

namespace Quick_Find
{
    public class QuickFind
    {
        private IList<int> nodes;
        public QuickFind(int number) => nodes = Enumerable.Range(0, number).ToList();


        public bool Connected(int first, int second) => nodes[first].Equals(nodes[second]);

        // too expensive operation
        public void Union(int first, int second)
        {
            int notValidValue = nodes[first];
            int targetValue = nodes[second];
            
            for (var i=0; i<nodes.Count; i++)
            {
                if (nodes[i].Equals(notValidValue))
                    nodes[i] = targetValue;
            }
        }
    }
}
