using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Matrix : IEnumerable<int[]>
    {
        private readonly int[][] _rows;
        private int _rowsFilled;

        public Matrix(int rows, int columns)
        {
            _rows = new int[rows][];

            for (int i = 0; i < _rows.Length; i++)
                _rows[i] = new int[columns];
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            if(m1.ColumnCount != m2.RowCount)
                throw new ArgumentException("m1's columns must equal m2's rows.");

            var m3 = new Matrix(m1.RowCount, m2.ColumnCount);
            
            for (int i = 0; i < m1.RowCount; i++)
                for (int j = 0; j < m1.ColumnCount; j++)
                    for (int k = 0; k < m2.ColumnCount; k++)
                        m3[i][k] += m1[i][j] * m2[j][k];

            return m3;
        }


        public int[] this[int index]
        {
            get { return _rows[index]; }
        }

        public int RowCount
        {
            get { return _rows.Length; }
        }

        public int ColumnCount
        {
            get { return _rows[0].Length; }
        }

        public void Add(params int[] row)
        {
            _rows[_rowsFilled++] = row;
        }

        public IEnumerator<int[]> GetEnumerator()
        {
            return _rows.AsEnumerable().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
