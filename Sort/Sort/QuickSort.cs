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

        //var items = new int[] { 1, 5, 3, 7, -10, -5, 11, 0, 10, -112 };
        //var result = QuickSort.Selection(items, i => i , 5);
        public static TSource Selection<TSource, TKey>(TSource[] array, Func<TSource, TKey> key, int k) where TKey : IComparable<TKey>
        {
            k--;
            array.Shuffle();
            int low = 0;
            int high = array.Length - 1;

            while(high > low)
            {
                int j = Partition(array, key, low, high);
                if (j < k) low = j + 1;
                else if (j > k) high = j - 1;
                else return array[k];
            }

            return array[k];
        }
    }
}
