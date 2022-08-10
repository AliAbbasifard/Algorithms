using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    internal static class SelectionSort
    {
        public static IEnumerable<IComparable> Sort(List<IComparable> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                var min = i;
                for (int j = i+1; j < list.Count; j++)
                {
                    if (list[j].CompareTo(list[min]) < 0)
                        min = j;
                }

                var x = list[i];
                list[i] = list[min];
                list[min] = x;
            }

            return list;
        }
    }
}
