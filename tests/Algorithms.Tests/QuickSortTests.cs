using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algorithms.Tests
{
    public class QuickSortTests
    {
        [Fact]
        public void Sort_SortsElements()
        {
            var nums = new List<int> {5, 3, 9, 7, 6, 1, 8, 4, 2};
            int[] expected = {1, 2, 3, 4, 5, 6, 7, 8, 9};

            IEnumerable<int> sorted = QuickSort.Sort(nums);

            Assert.Equal(expected, sorted);
        }
    }
}
