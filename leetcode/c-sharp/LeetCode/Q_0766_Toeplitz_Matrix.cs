using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class Q_0766_Toeplitz_Matrix
    {
        public static void Do()
        {
            int[][] arr = new int[2][];
            arr[0] = new int[3];

            IsToeplitzMatrix(arr);
        }
        public static bool IsToeplitzMatrix(int[][] matrix)
        {

            // int[m][n]  m x n 
            int m = matrix.Length;
            int n = matrix[0].Length;

            Console.WriteLine($"m:{m} n:{n}");

            int col = 0;
            int row = 0;

            while (col < m)
            {
                var val = matrix[col][row];

                var col_in = col + 1;
                var row_in = 1;

                while (col_in < m && row_in < n)
                {
                    if (matrix[col_in][row_in] != val)
                        return false;

                    col_in++;
                    row_in++;
                }
                col++;
            }

            col = 0;
            row = 1;

            while (row < n)
            {
                var val = matrix[col][row];
                var col_in = 1;
                var row_in = row + 1;

                while (col_in < m && row_in < n)
                {
                    if (matrix[col_in][row_in] != val)
                        return false;

                    col_in++;
                    row_in++;
                }
                row++;
            }

            return true;
        }
    }
}
