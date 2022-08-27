using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public static class QuickSort
    {
        private static int Partition<TSource, TKey>(TSource[] array, Func<TSource, TKey> key, int low, int high) where TKey : IComparable<TKey>
        {
            int i = low;
            int j = high + 1;

            while (true)
            {
                while (key(array[++i]).CompareTo(key(array[low])) < 0)
                    if (i == high) break;

                while (key(array[--j]).CompareTo(key(array[low])) > 0)
                    if (j == low) break;

                if (i >= j) break;

                (array[i], array[j]) = (array[j], array[i]);
            }

            (array[low], array[j]) = (array[j], array[low]);

            return j;
        }

        public static void Sort<TSource, TKey>(TSource[] array, Func<TSource, TKey> func, int low, int high) where TKey : IComparable<TKey>
        {
            if (high <= low) return;

            array.Shuffle();

            int j = QuickSort.Partition(array, func, low, high);

            Sort(array, func, low, j - 1);
            Sort(array, func, j+1, high);
        }

        private static void Shuffle<TSource>(this IList<TSource> list)
        {
            Random rnd = new Random();
            int n = list.Count;

            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                (list[k], list[n]) = (list[n], list[k]);
            }
        }
    }
}
