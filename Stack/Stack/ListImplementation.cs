using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class ListImplementation<T> : IStack<T>
    {
        private IList<T> numbers;
        public ListImplementation(IList<T> numbers) { this.numbers = numbers; }

        public bool IsEmpty() => numbers.Count == 0;

        public T Pop()
        {
            var item = numbers.Last();
            numbers.RemoveAt(numbers.Count - 1);

            return item;
        }

        public void Push(T item)
        {
            numbers.Add(item);
        }

        public int Size() => numbers.Count;
    }
}
