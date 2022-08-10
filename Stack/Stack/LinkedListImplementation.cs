using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class LinkedListImplementation<T> : IStack<T>
    {
        private LinkedList<T> numbers;

        public LinkedListImplementation(IList<T> numbers)
        {
            this.numbers = new LinkedList<T>(numbers);
        }

        public LinkedListImplementation()
        {
            this.numbers = new LinkedList<T>();
        }

        public bool IsEmpty() => this.numbers.Count == 0;

        public T Pop()
        {
            var item = numbers.First.Value;

            numbers.RemoveFirst();

            return item;
        }

        public void Push(T item) { numbers.AddFirst(item); }

        public int Size() => this.numbers.Count;
    }
}
