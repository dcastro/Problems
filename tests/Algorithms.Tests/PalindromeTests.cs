using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

namespace Algorithms.Tests
{
    public class PalindromeTests
    {
        [Theory]
        [InlineData(2133, 2222)]
        [InlineData(2113, 2222)]
        [InlineData(2101, 2112)]
        [InlineData(808, 818)]
        [InlineData(199, 202)]
        [InlineData(103, 111)]
        [InlineData(1, 2)]
        public void NextPalindrome(int k, int expectedPalindrome)
        {
            Assert.Equal(expectedPalindrome, Palindrome.Next(k));
        }

        [Theory]
        [PropertyData("NextPalindromeData")]
        public void NextPalindrome2(int k)
        {
            int pal = Palindrome.Next(k);

            Assert.True(pal.IsPalindrome());

            //if there's at least one number between "k" and "pal", those numbers must NOT be palindromes
            if (pal - k > 1)
            {
                IEnumerable<int> nonPalindromes = Enumerable.Range(k + 1, pal - k - 1);
                foreach (var nonPalindrome in nonPalindromes)
                    Assert.False(nonPalindrome.IsPalindrome());
            }
        }

        public static IEnumerable<object[]> NextPalindromeData
        {
            get { return Enumerable.Range(1, 1000).Select(i => new object[] {i}); }
        }

        [Theory]
        [InlineData("1221", true)]
        [InlineData("12321", true)]
        [InlineData("123a1", false)]
        [InlineData("12a1", false)]
        public void IsPalindrome(string str, bool isPalindrome)
        {
            Assert.Equal(isPalindrome, str.ToCharArray().IsPalindrome());
        }
    }
}
