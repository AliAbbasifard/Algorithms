using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public static class KnuthShuffle
    {
        private static Random _rnd = new Random();
        public static int[] Suffle(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int r = _rnd.Next(i + 1);

                int temp = numbers[i];
                numbers[i] = numbers[r];
                numbers[r] = temp;
            }

            return numbers;
        }
    }
}
