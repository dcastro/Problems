using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Extensions;

namespace Algorithms
{
    public static class Candy
    {
        /**
         * http://www.spoj.com/problems/CANDY/
         * 
         * Jennifer is a teacher in the first year of a primary school.
         * She has gone for a trip with her class today.
         * She has taken a packet of candies for each child. Unfortunatelly, the sizes of the packets are not the same.
         * 
         * Jennifer is afraid that each child will want to have the biggest packet of candies and this will lead to quarrels
         * or even fights among children. She wants to avoid this.
         * Therefore, she has decided to open all the packets, count the candies in each packet and move some candies from bigger
         * packets to smaller ones so that each packet will contain the same number of candies.
         * The question is how many candies she has to move.
         */

        //O(n log n) time
        public static int Solve(params int[] bags)
        {
            int sum = bags.Sum();

            //check if the candies can be evenly distributed among the bags
            if (sum%bags.Length != 0)
                return -1;

            //sort the bags
            QuickSort.SortInPlace(bags);
            int moveCount = 0;

            while (bags.Last() != bags.First())
            {
                //take a candy from the bag with the most candy
                //and put it in the bag with the least candy
                bags[bags.Length - 1]--;
                bags[0]++;
                moveCount++;

                //reorder these two bags
                SortFirstElement(bags);
                SortLastElement(bags);
            }

            return moveCount;
        }

        private static void SortFirstElement(int[] buffer)
        {
            int index = 0;
            while (index < buffer.Length - 1 && buffer[index] > buffer[index + 1])
            {
                buffer.Swap(index, index + 1);
                index++;
            }
        }

        private static void SortLastElement(int[] buffer)
        {
            int index = buffer.Length - 1;
            while (index > 0 && buffer[index - 1] > buffer[index])
            {
                buffer.Swap(index, index - 1);
                index--;
            }
        }
    }
}
