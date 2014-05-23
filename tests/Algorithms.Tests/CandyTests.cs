using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

namespace Algorithms.Tests
{
    public class CandyTests
    {
        [Theory]
        [InlineData(4, new[] {1, 1, 1, 1, 6})]
        [InlineData(-1, new[] {2, 3})]
        public void Test(int expected, int[] bags)
        {
            int moves = Candy.Solve(bags);

            Console.WriteLine(moves);
            Assert.Equal(expected, moves);
        }

        [Theory]
        [InlineData(4, new[] {1, 1, 1, 1, 6})]
        [InlineData(-1, new[] {2, 3})]
        public void Test_V2(int expected, int[] bags)
        {
            int moves = Candy.SolveV2(bags);

            Console.WriteLine(moves);
            Assert.Equal(expected, moves);
        }
    }
}
