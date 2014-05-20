using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algorithms.Tests
{
    public class LinkedListMidpointTest
    {
        [Fact]
        public void Midpoint_When_CountIsOdd()
        {
            var list = new LinkedList<int>
                {
                    new Node<int>(1),
                    new Node<int>(2),
                    new Node<int>(3),
                    new Node<int>(4),
                    new Node<int>(5)
                };

            Assert.Equal(3, list.Midpoint().Data);
        }

        [Fact]
        public void Midpoint_When_CountIsEven()
        {
            var list = new LinkedList<int>
                {
                    new Node<int>(1),
                    new Node<int>(2),
                    new Node<int>(3),
                    new Node<int>(4)
                };

            Assert.Equal(2, list.Midpoint().Data);
        }

        [Fact]
        public void MidPoint_When_CountIsZero()
        {
            var list = new LinkedList<int>
                {
                };

            Assert.Null(list.Midpoint());
        }

        [Fact]
        public void MidPoint_When_CountIsOne()
        {
            var list = new LinkedList<int>
            {
                new Node<int>(1)
            };

            Assert.Equal(1, list.Midpoint().Data);
        }
    }
}
