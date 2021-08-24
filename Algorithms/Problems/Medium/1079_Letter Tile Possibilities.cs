using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/letter-tile-possibilities/
    /// https://leetcode.com/problems/letter-tile-possibilities/discuss/1423076/C
    /// </summary>
    class _1079_Letter_Tile_Possibilities
    {
        public void Run()
        {
            var result = NumTilePossibilities("AAABBC");
        }

        public int NumTilePossibilities(string tiles)
        {
            var set = new HashSet<string>();
            Tracking(tiles.ToCharArray().ToList(), set);
            return set.Count;
        }

        public void Tracking(List<char> tiles, HashSet<string> set, string st = "")
        {
            if (!set.Contains(st) && st != "")
                set.Add(st);

            if (tiles.Count == 0)
                return;

            for (int i = 0; i < tiles.Count; i++)
            {
                var targetChar = tiles[i];
                var nextSt = st + targetChar;
                tiles.RemoveAt(i);
                Tracking(tiles, set, nextSt);
                tiles.Insert(i, targetChar);
            }
        }
    }
}
