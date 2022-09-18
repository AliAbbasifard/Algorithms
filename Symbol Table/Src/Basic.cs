using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Src
{
    public class Basic <TKey, TValue> : ISymbolTable<TKey, TValue> 
        where TKey : IComparable<TKey>
        where TValue : class                                                    
    {
        private IList<(TKey, TValue)> _items;
        public Basic(IList<(TKey, TValue)> items)
        {
            _items = items;
        }

        public bool Contains(TKey key)
        {
            for (int i = 0; i < _items.Count(); i++)
            {
                if (_items[i].Item1.CompareTo(key) == 0)
                    return true;
            }

            return false;
        }

        public void Delete(TKey key)
        {
            var index = -1;
            for (int i = 0; i < _items.Count(); i++)
            {
                if (_items[i].Item1.CompareTo(key) == 0)
                {
                    index = i;
                    break;
                }
            }

            if (index > -1)
                _items.RemoveAt(index);
        }

        public TValue Get(TKey key)
        {
            for (int i = 0; i < _items.Count(); i++)
            {
                if (_items[i].Item1.CompareTo(key) == 0)
                    return _items[i].Item2;
            }

            return null;
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
            for (int i = 0; i < _items.Count(); i++)
            {
                if (_items[i].Item1.CompareTo(key) == 0)
                    _items.RemoveAt(i);
            }

            _items.Add((key, value));
        }

        public int Size()
        {
            return _items.Count();
        }
    }
}
