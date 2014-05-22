using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algorithms.Tests
{
    public class KthLowestNumberFrom2SortedArraysTests
    {
        [Fact]
        public void Test()
        {
            int[] a = {1, 4, 5, 6, 7, 8};
            int[] b = {2, 3, 10, 11, 12, 13};

            int res = KthLowestNumberFrom2SortedArrays.Calc(a, b, 5);

            Console.WriteLine("!!! " + res);
        }
    }
}
