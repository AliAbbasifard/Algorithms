using System;
using System.Collections.Generic;
using System.Linq;
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

        public bool IsEmpty() => this.numbers.Count == 0;

        //public T Pop()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Push(T item)
        //{
        //    throw new NotImplementedException();
        //}

        public int Size() => this.numbers.Count;
    }
}
