using System;
using System.Collections.Generic;
using System.Linq;

namespace Src
{
    public class BinaryHeap<TSource> where TSource : IComparable<TSource>
    {
        public readonly IList<TSource> _items;
        public BinaryHeap(IList<TSource> items)
        {
            _items = items.ToList();
        }

        public void Swim(int k, Func<int, TSource> selector)
        {
            while (k > 0 && selector((k - 1) / 2).CompareTo(selector(k)) < 0)
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

        public void Sink(int k, Func<int, TSource> selector, int N)
        {
            while (2 * k + 1 <= N - 1)
            {
                int j = 2 * k + 1;
                if (j < _items.Count() - 1 && selector(j).CompareTo(selector(j + 1)) < 0)
                    j++;
                if (selector(k).CompareTo(selector(j)) > 0)
                    break;

                (_items[k], _items[j]) = (_items[j], _items[k]);
                k = j;
            }
        }

        public TSource DeleteMax(Func<int, TSource> selector)
        {
            TSource item = _items[0];
            (_items[0], _items[_items.Count() - 1]) = (_items[_items.Count() - 1], _items[0]);
            _items.RemoveAt(_items.Count() - 1);
            Sink(0, selector, _items.Count());
            return item;
        }
    }
    /// <summary>
    /// How to use: 
    /// 
    /// var values = new char[] {'S', 'O', 'R', 'T', 'E', 'X','A', 'M', 'P', 'L', 'E'};
    /// var source = values.ToList();
    /// var heap = MakeHeap<char>.Make(source);
    /// var sortedList = HeapSort<char>.Sort(heap);
    /// 
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    public static class MakeHeap<TSource> where TSource : IComparable<TSource>
    {
        public static BinaryHeap<TSource> Make(IList<TSource> sources)
        {
            BinaryHeap<TSource> binaryHeap = new BinaryHeap<TSource>(sources);

            for (int i = sources.Count() / 2 - 1; i >= 0 ; i--)
                binaryHeap.Sink(i, i => binaryHeap._items[i], binaryHeap._items.Count());

            return binaryHeap;
        }
    }
    public static class HeapSort<TSource> where TSource : IComparable<TSource>
    {
        public static IList<TSource> Sort(BinaryHeap<TSource> binaryHeap)
        {
            for (int i = binaryHeap._items.Count() - 1; i >=0 ; i--)
            {
                (binaryHeap._items[0], binaryHeap._items[i]) = (binaryHeap._items[i], binaryHeap._items[0]);
                binaryHeap.Sink(0, i => binaryHeap._items[i], i - 1);
            }

            return binaryHeap._items;
        }
    }
}
