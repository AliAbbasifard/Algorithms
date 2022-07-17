using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public interface IStack<T>
    {
        public void Push(T item);
        public T Pop();
        bool IsEmpty();
        int Size();
    }
}
