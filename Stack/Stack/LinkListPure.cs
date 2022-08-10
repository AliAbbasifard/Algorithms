using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class LinkListPure<T> : IStack<T>, IEnumerable<T>
    {
        private static Node _current = null;

        private class Node
        {
            public T Item { get; set; }
            public Node Next { get; set; }
        }

        public bool IsEmpty() => _current is null;
        public T Pop()
        {
            var item = _current.Item;

            _current = _current.Next;

            return item;
        }
        public void Push(T item)
        {
            var prevFirst = _current;

            var node = new Node { Item = item, Next = prevFirst };

            _current = node;
        }
        public int Size()
        {
            int size = 0;
            var x = _current;

            while (x.Next != null)
            {
                size++;
                x = x.Next;
            }

            size++;

            return size;
        }

        public IEnumerator<T> GetEnumerator() => new StackEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();


        private class StackEnumerator : IEnumerator<T>
        {
            private Node current = _current;

            public T Current { get { 
                    T item = current.Item;
                    current = current.Next; 
                    return item; 
                } }

            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
                
            }

            public bool MoveNext() => current != null;

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}
