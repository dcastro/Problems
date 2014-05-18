using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class SieveOfEratosthenes
    {
        public static IEnumerable<int> PrimesWithin(int range)
        {
            if (range < 2)
                throw new ArgumentOutOfRangeException("range", "range must be equal to or higher than 2.");

            // [0, range)
            bool[] marks = Enumerable.Range(0, range)
                                     .Select(e => true)
                                     .ToArray();

            for (int i = 2; i < Math.Sqrt(range); i++)
                if (marks[i])
                    for (int j = i*i; j < range; j += i)
                        marks[j] = false;

            return marks.Select((isPrime, index) => new {isPrime, index})
                        .Skip(2) //skip 0 and 1
                        .Where(pair => pair.isPrime)
                        .Select(pair => pair.index);
        }
    }
}
