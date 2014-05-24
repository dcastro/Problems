using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Algorithms.Tests
{
    public class MatrixTests
    {
        [Fact]
        public void Product()
        {
            var m1 = new Matrix(2, 3)
                {
                    {1, 2, 3},
                    {4, 5, 6}
                };

            var m2 = new Matrix(3, 2)
                {
                    {7, 8},
                    {9, 10},
                    {11, 12}
                };

            var m3 = m1*m2;

            Assert.Equal(2, m3.RowCount);
            Assert.Equal(2, m3.ColumnCount);

            Assert.Equal(new[] {58, 64}, m3[0]);
            Assert.Equal(new[] {139, 154}, m3[1]);

        }
    }
}
