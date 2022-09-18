using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Src
{
    public interface ISymbolTable<TKey, TValue> where TKey : IComparable<TKey>
    {
        void Put(TKey key, TValue value);
        TValue Get(TKey key);
        void Delete(TKey key); 
        bool Contains(TKey key);
        bool IsEmpty();
        int Size();
        IEnumerable<TKey> Keys();
    }
}
