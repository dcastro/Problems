using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Extensions;

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

        public static void SortInPlace<T>(T[] source, IComparer<T> cmp = null)
        {
            cmp = cmp ?? Comparer<T>.Default;

            SortInPlace(source, cmp, 0, source.Length - 1);
        }

        private static void SortInPlace<T>(T[] source, IComparer<T> cmp, int left, int right)
        {
            if (right - left < 1)
                return;

            int pivotIndex = ((right - left) >> 1) + left;

            pivotIndex = Partition(source, cmp, left, right, pivotIndex);

            SortInPlace(source, cmp, left, pivotIndex - 1);
            SortInPlace(source, cmp, pivotIndex + 1, right);
        }

        private static int Partition<T>(T[] source, IComparer<T> cmp, int left, int right, int pivotIndex)
        {
            T pivot = source[pivotIndex];

            //move pivot to the right
            source.Swap(pivotIndex, right);

            //separates the items less than pivot from the items greater than pivot
            int separator = left;

            for (int i = left; i < right; i++)
            {
                if (cmp.Compare(source[i], pivot) <= 0)
                {
                    source.Swap(separator, i);
                    separator++;
                }
            }

            //move pivot to its final place
            source.Swap(separator, right);

            return separator;
        }
    }
}
