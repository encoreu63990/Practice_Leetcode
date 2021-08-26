using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/merge-in-between-linked-lists/
    /// </summary>
    class _1669_Merge_In_Between_Linked_Lists
    {
        public void Run()
        {
            var list1 = new ListNode(0, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))));
            var a = 3;
            var b = 4;
            var list2 = new ListNode(1000, new ListNode(2000, new ListNode(3000)));
            var result = MergeInBetween(list1, a, b, list2);
        }

        public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
        {
            ListNode node1 = null;
            ListNode node2 = null;

            var tmpList1 = list1;
            for (int i = 0; node1 == null || node2 == null; i++)
            {
                if (i + 1 == a)
                    node1 = tmpList1;
                if (i == b)
                    node2 = tmpList1.next;

                tmpList1 = tmpList1.next;
            }

            var tmpList2 = list2;
            node1.next = list2;
            while (true)
            {
                if (tmpList2.next == null)
                {
                    tmpList2.next = node2;
                    break;
                }

                tmpList2 = tmpList2.next;
            }

            return list1;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
