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
            int maxIndex = 0;
            for (int i = 0; i < _items.Count; i++)
            {
                if (selector(_items[maxIndex]).CompareTo(selector(_items[i])) < 0)
                    maxIndex = i;
            }

            (_items[maxIndex], _items[_items.Count - 1]) = (_items[_items.Count - 1], _items[maxIndex]);

            var result = _items.Last();

            _items.RemoveAt(_items.Count - 1);

            return result;
        }
        public bool IsEmpty() => _items.Count == 0;
        public TSource Max() => _items.Max();
        public int Size() => _items.Count();
    }
}
