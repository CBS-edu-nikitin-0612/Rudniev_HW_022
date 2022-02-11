using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    static class MyClass
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] temp = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
                temp[i] = list[i];
            return temp;
        }
    }
}
