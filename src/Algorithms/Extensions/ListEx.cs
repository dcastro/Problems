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

        public static int MaxIndex<T>(this IList<T> source, IComparer<T> cmp, params int[] indices)
        {
            if (!indices.Any())
                throw new ArgumentException("indices must contain at least one element.", "indices");

            int max = indices[0];

            for (int i = 1; i < indices.Length; i++)
                if (cmp.Compare(source[indices[i]], source[max]) > 0)
                    max = indices[i];

            return max;
        }
    }
}
