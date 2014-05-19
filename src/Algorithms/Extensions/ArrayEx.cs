using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Extensions
{
    internal static class ArrayEx
    {
        public static void Swap<T>(this T[] source, int first, int second)
        {
            var temp = source[first];
            source[first] = source[second];
            source[second] = temp;
        }
    }
}
