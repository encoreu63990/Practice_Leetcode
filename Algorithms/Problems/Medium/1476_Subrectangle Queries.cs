using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/subrectangle-queries/
    /// 
    /// Case 1:
    /// [
    ///     "SubrectangleQueries","getValue","updateSubrectangle",
    ///     "getValue","getValue","updateSubrectangle","getValue","getValue"
    /// ]
    /// [[[[1,2,1],[4,3,4],[3,2,1],[1,1,1]]],[0,2],[0,0,3,2,5],[0,2],[3,1],[3,0,3,2,10],[3,1],[0,2]]
    /// </summary>
    class _1476_Subrectangle_Queries
    {
        public class SubrectangleQueries
        {
            private int[][] _rectangle;

            public SubrectangleQueries(int[][] rectangle)
            {
                _rectangle = rectangle;
            }

            public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
            {
                for (int i = row1; i <= row2; i++)
                {
                    for (int j = col1; j <= col2; j++)
                    {
                        _rectangle[i][j] = newValue;
                    }
                }
            }

            public int GetValue(int row, int col)
            {
                return _rectangle[row][col];
            }
        }
    }
}

/**
 * Your SubrectangleQueries object will be instantiated and called as such:
 * SubrectangleQueries obj = new SubrectangleQueries(rectangle);
 * obj.UpdateSubrectangle(row1,col1,row2,col2,newValue);
 * int param_2 = obj.GetValue(row,col);
 */
