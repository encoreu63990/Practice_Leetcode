using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/sort-the-matrix-diagonally/
    /// https://leetcode.com/problems/sort-the-matrix-diagonally/discuss/1412659/C-Simple-Solution
    /// </summary>
    class _1329_Sort_the_Matrix_Diagonally
    {
        public void Run()
        {
            var mat = new int[3][] {
                new int[] { 3, 3, 1, 1 },
                new int[] { 2, 2, 1, 2 },
                new int[] { 1, 1, 1, 2 },
            };

            DiagonalSort(mat);
            foreach (var row in mat)
            {
                foreach (var col in row)
                {
                    Console.Write(col + "  ");
                }
                Console.WriteLine();
            }
        }

        public int[][] DiagonalSort(int[][] mat)
        {
            int rowsLength = mat.Length;
            int colsLength = mat[0].Length;

            /*
                (0,0) , (0,1) , (0,2) , (0,3)
                (1,0) , (1,1) , (1,2) , (1,3)
                (2,0) , (2,1) , (2,2) , (2,3)
            */

            /*
                (0,0)->(1,1)->(2,2)
                (0,1)->(1,2)->(2,3)
                (0,2)->(1,3)
                (0,3)
            */
            for (int i = 0; i < colsLength; i++)
            {
                List<int> array = new List<int>();

                for (int j = 0, k = i; j < rowsLength && k < colsLength; j++, k++)
                {
                    array.Add(mat[j][k]);
                }

                array = array.OrderBy(c => c).ToList();

                for (int j = 0, k = i; j < rowsLength && k < colsLength; j++, k++)
                {
                    mat[j][k] = array[j];
                }
            }

            /*
                (1,0)->(2,1)
                (2,0)
            */
            for (int i = 1; i < rowsLength; i++)
            {
                List<int> array = new List<int>();

                for (int j = i, k = 0; j < rowsLength && k < colsLength; j++, k++)
                {
                    array.Add(mat[j][k]);
                }

                array = array.OrderBy(c => c).ToList();

                for (int j = i, k = 0; j < rowsLength && k < colsLength; j++, k++)
                {
                    mat[j][k] = array[k];
                }
            }

            return mat;
        }
    }
}
