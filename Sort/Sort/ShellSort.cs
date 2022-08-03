using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    internal static class ShellSort
    {
        public static IEnumerable<IComparable> Sort(IList<IComparable> nums)
        {
            int n = nums.Count;
            int h = 1;

            while (h < n / 3)
                h = (3 * h) + 1;

            while (h >= 1)
            {
                for (int i = h; i < n; i++)
                {
                    for (int j = i; j >= h && nums[j].CompareTo(nums[j-h]) < 0; j -= h)
                    {
                        var temp = nums[j];
                        nums[j] = nums[j-h];
                        nums[j-h] = temp;
                    }
                }

                h = h / 3;
            }

            return nums;
        }
    }
}
