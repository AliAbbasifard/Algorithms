﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public static class MergeSort
    {
        public static void Sort<TSource, TKey>(TSource[] array, Func<TSource, TKey> func, int low, int high) where TKey : IComparable<TKey>
        {
            if (low < high)
            {
                int mid = low + (high - low) / 2;

                Sort(array, func, low, mid);
                Sort(array, func, mid + 1, high);

                if (func(array[mid + 1]).CompareTo(func(array[mid])) > 0)
                {
                    // already sorted
                }

                Merge(array, low, mid, high, func);
            }
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
