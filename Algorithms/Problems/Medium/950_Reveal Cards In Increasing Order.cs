using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/reveal-cards-in-increasing-order/
    /// https://leetcode.com/problems/reveal-cards-in-increasing-order/discuss/1424543/C-Simple-Solution
    /// </summary>
    class _950_Reveal_Cards_In_Increasing_Order
    {
        public void Run()
        {
            var deck = new[] { 17, 13, 11, 2, 3, 5, 7 };
            var result = DeckRevealedIncreasing(deck);
        }

        /*
         * Array     
                7
                13 
                11 
                17 

         * Take 7
                7
                13      13      11
                11  ->  11  ->  17
                17      17      13

         * Take 11
                11
                17      17      13
                13  ->  13  ->  17
         
         * Take 13
                13      
                17  ->  17 ->  17

         * Take 17            

         * Inductive reasoning
               queue.Enqueue(card) <-  queue.Enqueue(queue.Dequeue()) <- queue
         */

        public int[] DeckRevealedIncreasing(int[] deck)
        {
            Array.Sort(deck);
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(deck.Last());

            for (int i = deck.Length - 2; i >= 0; i--)
            {
                queue.Enqueue(queue.Dequeue());
                queue.Enqueue(deck[i]);
            }

            var result = queue.ToArray();
            Array.Reverse(result);

            return result;
        }
    }
}
