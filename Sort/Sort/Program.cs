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
            Stopwatch stopwatch = new Stopwatch();
            var rnd = new Random();
            var nums = new List<IComparable>();
            for (int i = 0; i < 10000000; i++)
                nums.Add(rnd.Next(1, 10000000));

            Console.WriteLine("Size: 10000000");
            Console.WriteLine("--------------Shell-------------------------------");
            stopwatch.Start();
            var result = ShellSort.Sort(nums);
            stopwatch.Stop();
            Console.WriteLine($"{stopwatch.ElapsedMilliseconds} ms");
            Console.WriteLine("-------------Insertion----------------------------------");
            stopwatch.Reset();
            stopwatch.Start();
            var result2 = InsertionSort.Sort(nums);
            stopwatch.Stop();
            Console.WriteLine($"{stopwatch.ElapsedMilliseconds} ms");
            Console.WriteLine("--------------------------------------------------");
            stopwatch.Reset();

        }
    }
}
