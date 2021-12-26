using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Hard
{
    /// <summary>
    /// https://leetcode.com/problems/n-queens/
    /// https://leetcode.com/problems/n-queens/discuss/1648788/C-Simple-Solution
    /// </summary>
    public class _51_N_Queens
    {
        public void Run()
        {
            var result = new Solution().SolveNQueens(9);
        }

        public class Solution
        {
            public IList<IList<string>> SolveNQueens(int n)
            {
                var list = new List<IList<bool>>();
                for (int i = 0; i < n; i++)
                {
                    list.Add((new bool[n]).ToList());
                }
                var res = new List<IList<string>>();
                SolveNQueens(n, 0, list, res);
                return res;
            }

            private void SolveNQueens(int n, int q, IList<IList<bool>> current, IList<IList<string>> res)
            {
                if (q == n)
                {
                    Write(current, res);
                    return;
                }

                for (int r = 0; r < n; r++)
                {
                    var isAvailable = QueryIsAvailable(n, q, r, current);
                    if (!isAvailable)
                        continue;

                    Do(q, r, current);
                    SolveNQueens(n, q + 1, current, res);
                    Undo(q, r, current);
                }
            }

            private bool QueryIsAvailable(int n, int q, int r, IList<IList<bool>> current)
            {
                for (int i = 0; i <= q; i++)
                {
                    // Search top
                    if (current[i][r] != false)
                        return false;

                    // Search left-up
                    if (q - i >= 0 && r - i >= 0)
                    {
                        if (current[q - i][r - i] != false)
                            return false;
                    }

                    // Search right-up
                    if (q - i >= 0 && r + i < n)
                    {
                        if (current[q - i][r + i] != false)
                            return false;
                    }
                }

                return true;
            }

            private void Do(int q, int r, IList<IList<bool>> current)
            {
                current[q][r] = true;
            }

            private void Undo(int q, int r, IList<IList<bool>> current)
            {
                current[q][r] = false;
            }

            private void Write(IList<IList<bool>> current, IList<IList<string>> res)
            {
                var data = new List<string>();
                for (int i = 0; i < current.Count; i++)
                {
                    var tmp = string.Empty;
                    for (int j = 0; j < current.Count; j++)
                    {
                        if (current[i][j] == true)
                            tmp += "Q";
                        else
                            tmp += ".";
                    }
                    data.Add(tmp);
                }
                res.Add(data);
            }
        }
    }
}
