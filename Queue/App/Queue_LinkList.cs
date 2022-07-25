using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Queue_LinkList<T> : IQueue<T> where T : class
    {
        public T Dequeue()
        {
            if (IsEmpty())
                _last = null;

            T item = _first.Item;

            _first = _first.Next;

            return item;
        }

        public void Enqueue(T item)
        {
            Node l = new() { Item = item, Next = null };

            if(IsEmpty())
            {
                _first = l;
                _last = _first;
            }
            else
            {
                Node prev = _last;

                _last = l;

                prev.Next = _last;
            }
        }

        public bool IsEmpty() => _first is null;

        private Node _first, _last;

        private class Node
        {
            public T Item { get; set; }
            public Node Next { get; set; }
        }
    }
}
