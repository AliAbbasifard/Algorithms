using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    internal static class InsertionSort
    {
        public static TSource[] ISort<TSource, TKey>(this TSource[] array, Func<TSource, TKey> key) where TKey : IComparable
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i; j > 0 && key(array[j - 1]).CompareTo(key(array[j])) > 0; j--)
                    (array[j], array[j - 1]) = (array[j - 1], array[j]);
            }

            return array;
        }
    }
}
