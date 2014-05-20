using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Extensions;

namespace Algorithms
{
    public static class BubbleSort
    {
        public static void SortInPlace<T>(IList<T> source, IComparer<T> cmp = null)
        {
            cmp = cmp ?? Comparer<T>.Default;

            bool swapped;

            do
            {
                swapped = false;
                for (int i = 0; i <= source.Count - 2; i++)
                {
                    if (cmp.Compare(source[i], source[i + 1]) > 0)
                    {
                        source.Swap(i, i + 1);
                        swapped = true;
                    }
                }
            } while (swapped);
        }
    }
}
