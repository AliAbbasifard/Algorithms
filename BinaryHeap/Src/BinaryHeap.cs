using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Src
{
    public class BinaryHeap<TSource> where TSource : IComparable<TSource>
    {
        public readonly IList<TSource> _items;
        public BinaryHeap(IList<TSource> items)
        {
            _items = items.ToList();
        }

        private void Swim(int k, Func<int, TSource> selector) 
        {
            while (k > 0 && selector((k - 1)/2).CompareTo(selector(k)) < 0)
            {
                (_items[k], _items[(k - 1) / 2]) = (_items[(k - 1) / 2], _items[k]);
                k = (k - 1) / 2;
            }
        }

        public void Insert(TSource item, Func<int, TSource> selector)
        {
            _items.Add(item);
            Swim(_items.Count() - 1, selector);
        }
    }
}
