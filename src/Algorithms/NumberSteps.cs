using System;
using Algorithms.Utils;

namespace Algorithms
{
    public static class NumberSteps
    {
        /**
         * http://www.spoj.com/problems/NSTEPS/
         * 
         * 1112. Number Steps
         * 
         * Starting from point (0,0) on a plane, we have written all non-negative integers 0, 1, 2,... as shown in the figure.
         * For example, 1, 2, and 3 has been written at points (1,1), (2,0), and (3, 1) respectively and this pattern has continued.
         * 
         * http://www.spoj.com/content/steinersp:nsteps.gif
         * 
         * You are to write a program that reads the coordinates of a point (x, y),
         * and writes the number (if any) that has been written at that point.
         * (x, y) coordinates in the input are in the range 0...10000.
         * 
         */

        public static object Solve(int x, int y)
        {
            if (y != x && y != x - 2)
                return "No Number";

            if (y%2 == 0)
                return x + y;
            return x + y - 1;
        }

        public static void Run()
        {
            int count = Input.NextInt();

            while (count-- > 0)
            {
                string pair = Input.NextString();
                var coords = pair.Split(' ');
                Console.WriteLine(
                    Solve(
                        int.Parse(coords[0]),
                        int.Parse(coords[1])));
            }
        }
    }
}
