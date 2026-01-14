using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public class Helper1
    {
        public static void swap<T>(ref T x, ref T y) 
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }

        public static T add<T>(T x, T y) where T : notnull
        {
            dynamic a = x;
            dynamic b = y;
            return a+b;
        }
    }
}