using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Utils
{
    public static class Input
    {
        public static int NextInt()
        {
            var input = Console.ReadLine();
            return int.Parse(input);
        }
    }
}
