using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Queue_ResizingArray<T> : IQueue<T> where T : class
    {
        private static T[] array;
        private static int head = 0;
        private static int tail = 0;

        public Queue_ResizingArray(int capacity)
        {
            array = new T[capacity]; 
        }

        public T Dequeue()
        {
            T item = array[head];

            if (head == array.Length - 1)
                head = 0;
            else
            {
                array[head] = null;
                head++;
            }

            if (tail - head < array.Length / 4)
            {
                var a = new T[array.Length / 2];
                int index = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] is not null)
                    {
                        a[index] = array[i];
                        index++;
                    }
                }
                head = 0;
                tail = index;
                array = a;
            }

            return item;
        }

        public void Enqueue(T item)
        {
            if (IsEmpty() || tail == array.Length)
                tail = 0;

            array[tail] = item;
            tail = tail + 1;

            if (tail - head == array.Length)
            {
                var a = new T[array.Length * 2];
                for (int i = 0; i < array.Length; i++)
                    a[i] = array[i];

                array = a;
            }
        }

        public bool IsEmpty() => head == tail;
    }
}
