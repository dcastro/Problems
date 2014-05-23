using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

namespace Algorithms.Tests
{
    public class SquaresInGridTests
    {
        [Theory]
        [InlineData(2, 5)]
        [InlineData(1, 1)]
        [InlineData(8, 204)]
        public void Test(int n, int expectedSquares)
        {
            Assert.Equal(expectedSquares, SquaresInGrid.Solve(n));
        }
    }
}
