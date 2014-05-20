using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algorithms.Tests
{
    public class HeapSortTests
    {
        [Fact]
        public void SortInPlace_SortsElements()
        {
            int[] nums = { 5, 3, 9, 7, 6, 1, 8, 4, 2 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            HeapSort.SortInPlace(nums);

            Assert.Equal(expected, nums);
        }
    }
}
