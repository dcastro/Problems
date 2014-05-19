using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class QuickSort
    {
        public static List<T> Sort<T>(List<T> source, IComparer<T> cmp = null)
        {
            cmp = cmp ?? Comparer<T>.Default;

            if (source.Count <= 1)
                return source;

            int pivotIndex = source.Count >> 1;
            T pivot = source[pivotIndex];

            var less = new List<T>();
            var greater = new List<T>();

            IEnumerable<T> withoutPivot = source.Take(pivotIndex)
                                                .Concat(source.Skip(pivotIndex + 1));

            foreach (var elem in withoutPivot)
            {
                if (cmp.Compare(elem, pivot) > 0)
                    greater.Add(elem);
                else
                    less.Add(elem);
            }

            var res = Sort(less);
            res.Add(pivot);
            res.AddRange(Sort(greater));

            return res;
        }
    }
}
