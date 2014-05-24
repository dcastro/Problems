using System;
using System.Globalization;
using System.Linq;
using Algorithms.Utils;

namespace Algorithms
{
    public static class Palindrome
    {
        /**
         * http://www.spoj.com/problems/PALIN/
         * 
         * The Next Palindrome
         * 
         * A positive integer is called a palindrome if its representation in the decimal system is the same when read from left to right and from right to left.
         * For a given positive integer K of not more than 1000000 digits, write the value of the smallest palindrome larger than K to output.
         * Numbers are always displayed without leading zeros.
         * 
         * Input:
         * The first line contains integer t, the number of test cases. Integers K are given in the next t lines.
         * 
         * Output:
         * For each K, output the smallest palindrome larger than K.
         * 
         * Example:
         * Input:
         * 2
         * 808
         * 2133
         * Output:
         * 818
         * 2222
         */

        public static int Next(int k)
        {
            if (k.IsPalindrome())
                k++;

            int[] digits = Next(k.ToString(CultureInfo.InvariantCulture)
                                 .Select(ch => (int) Char.GetNumericValue(ch))
                                 .ToArray());

            return DigitsToNumber(digits);
        }

        public static string Next(string k)
        {
            int[] digits = k.Select(ch => (int) Char.GetNumericValue(ch))
                            .ToArray();

            if (digits.IsPalindrome())
                digits = Increment(digits, digits.Length - 1);

            int[] palindrome = Next(digits);

            return string.Join("", palindrome.Select(i => i.ToString(CultureInfo.InvariantCulture)).ToArray());
        }

        private static int[] Next(int[] k)
        {
            /**
             * The basic idea behind the algorithm is to mirror the left part of the number.
             * I.e., to transpose the most significant digits (MSDs) on top of the least significant digits in reverse order.
             * E.g.,
             * Input:   [4321] => [43][21]
             * Mirror:  [43][34] => [4334] 
             * 
             * If the mirrored number is less than "k" (e.g., k = 1234, mirror(k) = 1221, which is less than "k"),
             * then we increment the number formed by the most significant digits by 1 before mirroring the number.
             * E.g.,
             * Input:           [12][34]
             * Increment MSDs:  [13][34]
             * Mirror:          [13][31] => [1331]
             * 
             */

            if (!IsMirrorValid(k))
                k = Increment(k, (k.Length - 1)/2);

            MirrorMSDs(k);

            return k;
        }

        private static int DigitsToNumber(int[] digits)
        {
            int number = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                int digit = digits[digits.Length - 1 - i];

                number += (int) (digit*Math.Pow(10, i));
            }

            return number;
        }

        private static bool IsMirrorValid(int[] k)
        {
            int left = (k.Length - 1)/2;
            int right = k.Length - 1 - left;

            while (left >= 0)
            {
                if (k[left] > k[right])
                    return true;
                if (k[left] < k[right])
                    return false;

                left--;
                right++;
            }

            return true;
        }

        private static int[] Increment(int[] k, int end)
        {
            int current = end;
            do
            {
                k[current]++;

                if (k[current] == 10)
                    k[current] = 0;

            } while (k[current--] == 0 && current >= 0);

            //If all digits are now zero (i.e., 999 => 000)
            //create new array with 1 more digit (i.e., 000 => 1000)
            //Note: in this case, we don't need to worry about the digits after "end"
            if (current < 0 && k[0] == 0)
            {
                k = new int[k.Length + 1];
                k[0] = 1;
            }

            return k;
        }

        private static void MirrorMSDs(int[] k)
        {
            int left = (k.Length - 1)/2;
            int right = k.Length - 1 - left;

            while (left >= 0)
            {
                k[right] = k[left];
                left--;
                right++;
            }
        }

        public static bool IsPalindrome<T>(this T[] source)
        {
            int left = 0, right = source.Length - 1;

            while (left < right)
                if (!source[left++].Equals(source[right--]))
                    return false;
            return true;
        }


        public static bool IsPalindrome(this int source)
        {
            return source.ToString(CultureInfo.InvariantCulture)
                         .ToCharArray()
                         .IsPalindrome();
        }

        public static void Run()
        {
            int count = Input.NextInt();

            while (count-- > 0)
            {
                string k = Input.NextString();
                Console.WriteLine(Next(k));
            }
        }
    }
}
