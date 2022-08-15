using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 5, 7, -1, 3, 9, 11, 6, -100};

            BottomUpMergeSort.Sort(numbers, i => i);
        }
    }
}
