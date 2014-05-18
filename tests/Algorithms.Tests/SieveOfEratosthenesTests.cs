using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algorithms.Tests
{
    public class SieveOfEratosthenesTests
    {
        [Fact]
        public void PrimesWithin_Returns_PrimeNumbersWithinRange()
        {
            int[] expectedPrimes =
                {
                    2, 3, 5, 7, 11, 13, 17, 19, 23, 29,
                    31, 37, 41, 43, 47, 53, 59, 61, 67,
                    71, 73, 79, 83, 89, 97, 101
                };
            var primes = SieveOfEratosthenes.PrimesWithin(102);

            Assert.Equal(expectedPrimes, primes);
        }
    }
}
