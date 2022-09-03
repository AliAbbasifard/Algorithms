using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Src
{
    public class PriorityQueue<TSource, TKey> : IPriorityQueue<TSource, TKey> where TKey : IComparable<TKey>
    {
        private IList<TSource> _items;
        public PriorityQueue(IList<TSource> items)
        {
            _items = items;
        }
        public void Add(TSource item) { _items.Add(item); }
        public TSource DeleteMax(Func<TSource, TKey> selector)
        {
            TSource max = _items[0];

            for (int i = 1; i < _items.Count; i++)
            {
                if (selector(max).CompareTo(selector(_items[i])) < 0)
                    max = _items[i];
            }

            _items.Remove(max);

            return max;
        }
        public bool IsEmpty() => _items.Count == 0;
        public TSource Max() => _items.Max();
        public int Size() => _items.Count();
    }
}
