using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public class Helper2<T> where T : notnull
    {
        public static void swap(ref T x, ref T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }

        public static T add(T x, T y)
        {
            dynamic a = x;
            dynamic b = y;
            return a+b;
        }
    }
}