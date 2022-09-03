using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Src
{
    public interface IPriorityQueue<TSource, TKey> where TKey : IComparable<TKey>
    {
        void Add(TSource item);
        TSource DeleteMax(Func<TSource, TKey> selector);
        bool IsEmpty();
        TSource Max();
        int Size();
    }
}
