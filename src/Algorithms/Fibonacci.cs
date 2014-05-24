using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Fibonacci
    {
        private static readonly Matrix A = new Matrix(2, 2)
            {
                {1, 1},
                {1, 0}
            };

        private static readonly Matrix Base = new Matrix(2, 1)
            {
                1,
                0
            };

        /**
         * [1 1] * [f(n-1)] = [f(n)  ]
         * [1 0]   [f(n-2)]   [f(n-1)]
         * 
         * which means,
         * 
         * [f(n)  ] = A^(n-1) * [f(1)]
         * [f(n-1)]             [f(0)]
         * 
         * A^n = A^(n/2) * A^(n/2)
         */
        
        /// <summary>
        /// Find the nth fibonacci nunmber in O(log n)
        /// </summary>
        public static int FindNth(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            var m = Pow(A, n - 1)*Base;

            return m[0][0];
        }

        private static Matrix Pow(Matrix m, int power)
        {
            if (power == 1)
                return m;

            //m^n = m^(n/2) * m^(n/2)
            var pow = Pow(m, power/2);

            pow *= pow;

            //if "n" is even, then m^n = m^(n/2) * m^(n/2) * m
            //(because n/2 will round towards zero - aka, round down assuming n >= 0)
            if (power%2 != 0)
                pow *= m;

            return pow;
        }
    }
}
