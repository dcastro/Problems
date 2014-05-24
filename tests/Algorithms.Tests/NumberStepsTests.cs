using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

namespace Algorithms.Tests
{
    public class NumberStepsTests
    {
        [Theory]
        [InlineData(4, 2, 6)]
        [InlineData(6, 6, 12)]
        [InlineData(3, 4, "No Number")]
        public void Test(int x, int y, object expected)
        {
            Assert.Equal(expected, NumberSteps.Solve(x, y));
        }
    }
}
