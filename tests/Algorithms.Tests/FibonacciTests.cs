using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

namespace Algorithms.Tests
{
    public class FibonacciTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 5)]
        [InlineData(6, 8)]
        [InlineData(7, 13)]
        [InlineData(8, 21)]
        [InlineData(9, 34)]
        [InlineData(10, 55)]
        public void FindNth(int nth, int fib)
        {
            Assert.Equal(fib, Fibonacci.FindNth(nth));
        }
    }
}
