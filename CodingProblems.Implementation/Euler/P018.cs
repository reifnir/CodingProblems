using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingProblems.Implementation.Euler
{
    public class P018
    {
        public static int GetMaximumChildPathSum(int[][] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                UpdateWithMaxPaths(values, i);                
            }
            return values.Last().Max();
        }

        private static void UpdateWithMaxPaths(int[][] values, int rowIndex)
        {
            if (IsTopRow(rowIndex))
                return;

            var row = values[rowIndex];
            for (int columnIndex = 0; columnIndex < row.Length; columnIndex++)
            {
                row[columnIndex] += GreaterOfTheTwoParents(values, rowIndex, columnIndex);
            }
        }

        private static int GreaterOfTheTwoParents(int[][] values, int rowIndex, int columnIndex)
        {
            var leftParent =  IsLeftmostColumn(columnIndex)
                ? 0
                : LeftParent(values, rowIndex, columnIndex);
            var rightParent = IsRightmostColumn(columnIndex, values[rowIndex])
                ? 0
                : RightParent(values, rowIndex, columnIndex);

            return (leftParent > rightParent)
                ? leftParent
                : rightParent;
        }

        private static bool IsRightmostColumn(int columnIndex, int[] row)
        {
            return columnIndex + 1 == row.Length;
        }

        private static bool IsLeftmostColumn(int columnIndex)
        {
            return columnIndex == 0;
        }

        private static int RightParent(int[][] values, int rowIndex, int columnIndex)
        {
            return values[rowIndex - 1][columnIndex];
        }

        private static int LeftParent(int[][] values, int rowIndex, int columnIndex)
        {
            return values[rowIndex - 1][columnIndex - 1];
        }

        private static bool IsTopRow(int rowIndex)
        {
            return rowIndex == 0;
        }
    }
}
