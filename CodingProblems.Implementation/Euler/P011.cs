using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingProblems.Implementation.Euler
{
    public class P011
    {
        private enum Direction
        {
            Downward,
            Rightward,
            DiagonallyDownLeft,
            DiagonallyDownRight
        }
        private readonly int[,] matrix;
        private readonly int numbersInARow;
        private const int ROW_DIMENSION = 0;
        private const int COLUMN_DIMENSION = 1;
        public P011(int[,] _matrix, int _numbersInARow)
        {
            matrix = _matrix;
            numbersInARow = _numbersInARow;
        }

        public int GetMaximumProduct()
        {
            var products = new List<int>();

            for (int row = 0; row <= GetMaxRowIndex(); row++)
            {
                for (int column = 0; column <= GetMaxColumnIndex(); column++)
                {
                    if (CanPositionEvaluateDownwardProduct(row))
                        products.Add(GetDownwardProduct(row, column));
                    if (CanPositionEvaluateRightwardProduct(column))
                        products.Add(GetRightwardProduct(row, column));
                    if (CanPositionEvaluateDownLeftwardProduct(row, column))
                        products.Add(GetDownLeftwardProduct(row, column));
                    if (CanPositionEvaluateDownRightwardProduct(row, column))
                        products.Add(GetDownRightwardProduct(row, column));
                }
            }
            return products.Max();
        }

        private int GetProduct(int row, Func<int, int> nextRow, int column, Func<int, int> nextColumn)
        {
            var product = 1;

            var currentRow = row;
            var currentColumn = column;
            for (int i = 0; i < numbersInARow; i++)
            {
                product *= matrix[currentRow, currentColumn];
                currentRow = nextRow(currentRow);
                currentColumn = nextColumn(currentColumn);
            }
            return product;
        }
        private Func<int,int> Stay = (x) => x;
        private Func<int, int> Previous = (x) => x - 1;
        private Func<int, int> Next = (x) => x + 1;

        private int GetDownRightwardProduct(int row, int column)
        {
            return GetProduct(row, Next, column, Next);
        }

        private int GetDownLeftwardProduct(int row, int column)
        {
            return GetProduct(row, Next, column, Previous);
        }

        private int GetRightwardProduct(int row, int column)
        {
            return GetProduct(row, Stay, column, Next);
        }

        private int GetDownwardProduct(int row, int column)
        {
            return GetProduct(row, Next, column, Stay);
        }

        public int GetMaxColumnIndex()
        {
            return matrix.GetLength(COLUMN_DIMENSION) - 1;
        }

        public int GetMaxRowIndex()
        {
            return matrix.GetLength(ROW_DIMENSION) - 1;
        }

        public bool CanPositionEvaluateRightwardProduct(int column)
        {
            return column >= 0 && (column + numbersInARow - 1) <= GetMaxColumnIndex();
        }
        public bool CanPositionEvaluateDownwardProduct(int row)
        {
            return row >= 0 && (row + numbersInARow - 1) <= GetMaxRowIndex();
        }
        public bool CanPositionEvaluateDownRightwardProduct(int row, int column)
        {
            return CanPositionEvaluateDownwardProduct(row) && CanPositionEvaluateRightwardProduct(column);
        }
        public bool CanPositionEvaluateDownLeftwardProduct(int row, int column)
        {
            return CanPositionEvaluateDownwardProduct(row) && CanPositionEvaluateRightwardProduct(column - 3);
        }
    }
}
