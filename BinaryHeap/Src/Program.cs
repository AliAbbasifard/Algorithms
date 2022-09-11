using System;
using System.Linq;

namespace Src
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new char[] {
                'S', 'O', 'R', 'T', 'E', 'X','A', 'M', 'P', 'L', 'E'
            };
            var source = values.ToList();
            var heap = MakeHeap<char>.Make(source);
            var result = HeapSort<char>.Sort(heap);
        }
    }
}
