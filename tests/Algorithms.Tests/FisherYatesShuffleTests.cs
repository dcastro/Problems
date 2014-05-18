using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algorithms.Tests
{
    public class FisherYatesShuffleTests
    {
        [Fact]
        public void ShuffleInPlace_ShufflesElements()
        {
            var rnd = new Random(1);
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] expected = {7, 9, 5, 2, 10, 8, 6, 4, 1, 3};
            FisherYatesShuffle.ShuffleInPlace(arr, rnd);

            Assert.Equal(expected, arr);
        }

        [Fact]
        public void Shuffle_ShufflesElements()
        {
            var rnd = new Random(1);
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] expected = {9, 3, 7, 5, 4, 1, 10, 8, 2, 6};
            arr = FisherYatesShuffle.Shuffle(arr, rnd);

            Assert.Equal(expected, arr);
        }

        [Fact]
        public void ShuffleEnumerable_ShufflesElements()
        {
            var rnd = new Random(1);
            IEnumerable<int> arr = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            IEnumerable<int> expected = new[] {9, 3, 7, 5, 4, 1, 10, 8, 2, 6};
            arr = FisherYatesShuffle.Shuffle(arr.AsEnumerable(), rnd);

            Assert.Equal(expected, arr);
        }
    }
}
