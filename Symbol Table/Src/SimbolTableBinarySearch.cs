using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Src
{
    public class SimbolTableBinarySearch<TKey, TValue> : ISymbolTable<TKey, TValue>
        where TKey : IComparable<TKey>
        where TValue : class
    {
        private IList<(TKey, TValue)> _items;
        public SimbolTableBinarySearch(IList<(TKey, TValue)> items)
        {
            _items = items;
        }

        public bool Contains(TKey key)
        {
            var item = Get(key);

            return item is not null;
        }

        public void Delete(TKey key)
        {
            var index = Rank(key);

            if (index > -1)
                _items.RemoveAt(index);
        }

        public TValue Get(TKey key)
        {
            if (IsEmpty()) return null;
            int i = Rank(key);
            if (i < _items.Count() && _items[i].Item1.CompareTo(key) == 0) return _items[i].Item2;
            else return null;
        }

        public bool IsEmpty()
        {
            return _items.Count() == 0;
        }

        public IEnumerable<TKey> Keys()
        {
            var keys = new List<TKey>();
            for (int i = 0; i < _items.Count(); i++)
                keys.Add(_items[i].Item1);

            return keys;
        }

        public void Put(TKey key, TValue value)
        {
            var index = Rank(key);
            _items.RemoveAt(index);
            _items.Insert(index, (key, value));
        }

        public int Size()
        {
            return _items.Count();
        }

        private int Rank(TKey key)
        {
            int low = 0;
            int high = _items.Count() - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                int cmp = key.CompareTo(_items[mid].Item1);
                if (cmp < 0) high = mid - 1;
                else if (cmp > 0) low = mid + 1;
                else if (cmp == 0) return mid;
            }

            return low;
        }
    }
}
