using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class FisherYatesShuffle
    {
        private static readonly Lazy<Random> LazyRnd = new Lazy<Random>(() => new Random());
 
        private static Random Rnd
        {
            get { return LazyRnd.Value; }
        }

        public static void ShuffleInPlace<T>(T[] array, Random rnd = null)
        {
            rnd = rnd ?? Rnd;

            Action<T[], int, int> swap = (arr, i, j) =>
                {
                    var temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                };

            for (int i = array.Length - 1; i >= 1; i--)
            {
                int j = rnd.Next(0, i + 1);
                swap(array, i, j);
            }
        }

        public static T[] Shuffle<T>(T[] array, Random rnd = null)
        {
            rnd = rnd ?? Rnd;
            var shuffled = new T[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                int j = rnd.Next(0, i + 1);
                if (j != i)
                    shuffled[i] = shuffled[j];
                shuffled[j] = array[i];
            }

            return shuffled;
        }

        public static IEnumerable<T> Shuffle<T>(IEnumerable<T> source, Random rnd = null)
        {
            rnd = rnd ?? Rnd;
            var shuffled = new List<T>();

            foreach (var elem in source)
            {
                int j = rnd.Next(0, shuffled.Count + 1);
                if (j == shuffled.Count)
                {
                    shuffled.Add(elem);
                }
                else
                {
                    shuffled.Add(shuffled[j]);
                    shuffled[j] = elem;
                }
            }

            return shuffled;
        }
    }
}
