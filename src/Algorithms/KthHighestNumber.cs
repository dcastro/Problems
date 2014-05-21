using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Extensions;

namespace Algorithms
{
    public static class KthHighestNumber
    {
        //O(n*k) time
        //O(k) space
        //assumes source.Count > k
        //assumes k > 0
        public static int Calc(IEnumerable<int> source, int k)
        {
            /**
             * We create a buffer with K + 1 elements.
             * For the first k numbers we fetch from the source, we simply insert them in the buffer in any order
             * When the buffer becomes full, we sort it once. From now on, buffer[1 -> k] represent the k highest numbers (sorted).
             * At each iteration, we fetch an integer and put it on buffer[0], and move it to its proper place.
             * When we're done fetching integers from source, the kth highest number will be at buffer[1]
             */
            var buffer = new int[k + 1];

            int index = 0;
            foreach (var i in source)
            {
                if (index < k + 1)
                {
                    buffer[index] = i;

                    if (index == k)
                        BubbleSort.SortInPlace(buffer);

                    index++;
                }
                else
                {
                    buffer[0] = i;
                    SortFirstElement(buffer);
                }
            }

            return buffer[1];
        }

        private static void SortFirstElement(int[] buffer)
        {
            int index = 0;
            while (index < buffer.Length - 1 && buffer[index] > buffer[index + 1])
            {
                buffer.Swap(index, index + 1);
                index++;
            }
        }

    }
}
