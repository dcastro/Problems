using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class KthLowestNumberFrom2SortedArrays
    {
        public static int Calc(int[] a, int[] b, int k)
        {
            int leftA = 0, leftB = 0;
            int rightA = Math.Min(a.Length - 1, k - 1);
            int rightB = Math.Min(b.Length - 1, k - 1);

            int midA = rightA/2;
            int midB = rightB/2;

            while (leftA <= rightA && leftB <= rightB)
            {
                int total = midA + midB + 2;

                if (a[midA] < b[midB])
                {
                    if (total > k)
                    {
                        rightB = midB - 1;
                        midB = ((rightB - leftB)/2) + leftB;
                    }
                    else
                    {
                        leftA = midA + 1;
                        midA = ((rightA - leftA)/2) + leftA;
                    }
                }
                else //if a[midA] >= b[midB]
                {
                    if (total > k)
                    {
                        rightA = midA - 1;
                        midA = ((rightA - leftA)/2) + leftA;
                    }
                    else
                    {
                        leftB = midB + 1;
                        midB = ((rightB - leftB)/2) + leftB;
                    }
                }
            }

            if (leftA <= rightA)
                return a[k - leftB - 1];
            return b[k - leftA - 1];
        }
    }
}
