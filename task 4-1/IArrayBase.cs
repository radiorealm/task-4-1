using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4_1
{
    interface IArrayBase<T>
    {
        void Add(T element);

        void Remove(T element);

        int Length();
        int Length(Func<T, bool> func);

        bool Check(T element);

        T Find(Func<T, bool> func);

        T[] FindAll(Func<T, bool> func);
        T[] FindAll<TResult>();
    }
}
