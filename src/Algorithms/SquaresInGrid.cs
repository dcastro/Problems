using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Utils;

namespace Algorithms
{
    public static class SquaresInGrid
    {
        /**
         * http://www.spoj.com/problems/SAMER08F/
         * 
         * Feynman
         * 
         * Richard Phillips Feynman was a well known American physicist and a recipient of the Nobel Prize in Physics.
         * He worked in theoretical physics and also pioneered the field of quantum computing.
         * He visited South America for ten months, giving lectures and enjoying life in the tropics.
         * He is also known for his books "Surely You're Joking, Mr. Feynman!" and "What Do You Care What Other People Think?", which include some of his adventures below the equator.
         * 
         * His life-long addiction was solving and making puzzles, locks, and cyphers.
         * Recently, an old farmer in South America, who was a host to the young physicist in 1949, found some papers and notes that is believed to have belonged to Feynman.
         * Among notes about mesons and electromagnetism, there was a napkin where he wrote a simple puzzle: "how many different squares are there in a grid of N ×N squares?".
         * In the same napkin there was a drawing which is reproduced below, showing that, for N=2, the answer is 5.
         * 
         * http://www.spoj.com/content/disatoba:feynman.gif
         * 
         */

        //O(n)
        public static int Solve(int n)
        {
            //f(n) = Σ (1>= i >= n) (i^2)
            int squares = 0;

            for (int i = 1; i <= n; i++)
                squares += i*i;

            return squares;
        }

        public static void Run()
        {
            int n;

            while ((n = Input.NextInt()) != 0)
                Console.WriteLine(Solve(n));
        }
    }
}
