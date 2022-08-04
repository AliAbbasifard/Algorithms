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
            
        }

        

        private static int[] GetRandomArray(int length)
        {
            var random = new Random();

            return Enumerable.Range(0, length)
                .Select(_ => random.Next())
                .ToArray();
        }

        private static List<int[]> CreateArrays(int count)
        {
            var baseArray = GetRandomArray(100_000);

            return Enumerable.Range(0, count)
                .Select(_ => (baseArray.Clone() as int[])!)
                .ToList();
        }
    }
}
