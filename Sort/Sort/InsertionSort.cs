using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    internal static class InsertionSort
    {
        public static IEnumerable<IComparable> Sort(List<IComparable> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i; j > 0 ; j--)
                {
                    if (list[j - 1].CompareTo(list[j]) > 0)
                    {
                        var x = list[j];
                        list[j] = list[j - 1];
                        list[j - 1] = x;
                    }
                    else
                        break;
                }
            }

            return list;
        }
    }
}
