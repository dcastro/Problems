using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Extensions;

namespace Algorithms
{
    public static class HeapSort
    {
        public static void SortInPlace<T>(IList<T> source, IComparer<T> cmp = null)
        {
            cmp = cmp ?? Comparer<T>.Default;

            Heapify(source, cmp);

            int end = source.Count - 1;

            //[0, end] is a heap
            //[end, Count-1] contains the elements that have already been sorted
            while (end > 0)
            {
                source.Swap(end, 0);            //take the greatest element (the root) from the heap, and move it to the end.
                end--;                          //reduce the heap size
                SiftDown(source, cmp, 0, end);  //restore the heap property
            }
        }

        private static void Heapify<T>(IList<T> source, IComparer<T> cmp)
        {
            int start = (int) Math.Floor((source.Count - 2.0)/2.0);
            int end = source.Count - 1;

            //bottom-up
            while (start >= 0)
            {
                SiftDown(source, cmp, start, end);
                start--;
            }
        }

        private static void SiftDown<T>(IList<T> source, IComparer<T> cmp, int start, int end)
        {
            int root = start;

            //while root has at least one child
            while (root*2 + 1 <= end)
            {
                int leftChild = root*2 + 1;
                int rightChild = leftChild + 1;

                //check if either the right child or the left child are greater than root
                int toSwap = rightChild < end
                                 ? source.MaxIndex(cmp, root, leftChild, rightChild)
                                 : source.MaxIndex(cmp, root, leftChild);

                //if the root is greater than both children
                if (toSwap == root)
                    return;

                //continue sifting down the child
                source.Swap(root, toSwap);
                root = toSwap;
            }
        }
    }
}
