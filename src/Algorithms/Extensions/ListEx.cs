using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Extensions
{
    internal static class ListEx
    {
        public static void Swap<T>(this IList<T> source, int first, int second)
        {
            var temp = source[first];
            source[first] = source[second];
            source[second] = temp;
        }
    }
}
