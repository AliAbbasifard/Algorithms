using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    internal static class ShellSort
    {
        public static TSource[] SSort<TSource>(this TSource[] array) where TSource : IComparable
        {
            var h = 1;

            while (h < array.Length / 3)
            {
                h = h * 3 + 1;
            }

            while (h >= 1)
            {
                for (var i = h; i < array.Length; i++)
                {
                    for (var j = i; j >= h && array[j].CompareTo(array[j - h]) < 0; j -= h)
                        (array[j], array[j - h]) = (array[j - h], array[j]);
                }

                h /= 3;
            }

            return array;
        }
    }
}
