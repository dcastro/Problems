using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algorithms.Tests
{
    public class KthHighestNumberTests
    {
        [Fact]
        public void Test()
        {
            int max = 100;
            int k = 7;
            int[] nums = Enumerable.Range(0, max + 1).ToArray();

            FisherYatesShuffle.ShuffleInPlace(nums);

            int hi = KthHighestNumber.Calc(nums, k);

            Assert.Equal(max - k + 1, hi);
        }

    }
}
