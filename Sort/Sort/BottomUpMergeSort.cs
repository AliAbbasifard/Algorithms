using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public static class BottomUpMergeSort
    {
        public static void Sort<TSource, TKey>(TSource[] array, Func<TSource, TKey> func) where TKey : IComparable<TKey>
        {
            int size = array.Length;

            for (int sortedSize = 1; sortedSize < size; sortedSize *= 2)
                for (int low = 0; low < size - sortedSize; low += 2 * sortedSize)
                    Merge(array, low, low + sortedSize - 1, Math.Min(low + sortedSize + sortedSize - 1, size - 1), func);
        }
        private static void Merge<TSource, TKey>(TSource[] array, int low, int mid, int high, Func<TSource, TKey> func) where TKey : IComparable<TKey>
        {
            int n1 = mid - low + 1;
            int n2 = high - mid;

            TSource[] L = new TSource[n1];
            TSource[] R = new TSource[n2];
            int i, j;

            for (i = 0; i < n1; ++i)
                L[i] = array.ElementAt(low + i);
            for (j = 0; j < n2; ++j)
                R[j] = array.ElementAt(mid + 1 + j);

            i = 0;
            j = 0;

            int k = low;
            while (i < n1 && j < n2)
            {
                if (func(L[i]).CompareTo(func(R[j])) < 0)
                {
                    array[k] = L[i];
                    i++;
                }
                else
                {
                    array[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                array[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                array[k] = R[j];
                j++;
                k++;
            }
        }
    }
}
