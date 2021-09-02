using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/battleships-in-a-board/
    /// https://leetcode.com/problems/battleships-in-a-board/discuss/1440113/C-Solution
    /// </summary>
    class _419_Battleships_in_a_Board
    {
        public int CountBattleships(char[][] board)
        {
            int counter = 0;

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == 'X')
                    {
                        counter++;
                        Search(board, i, j);
                    }
                }
            }

            return counter;
        }

        public void Search(char[][] board, int i, int j)
        {
            if (i >= board.Length || j >= board[0].Length || i < 0 || j < 0)
                return;

            if (board[i][j] != 'X')
                return;

            board[i][j] = '.';
            Search(board, i - 1, j);
            Search(board, i + 1, j);
            Search(board, i, j - 1);
            Search(board, i, j + 1);
        }
    }
}

