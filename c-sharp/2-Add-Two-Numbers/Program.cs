using System;
using System.Collections.Generic;

//  https://leetcode.com/problems/add-two-numbers/

namespace Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // empty test () []
            RunTest(new int[] { }, new int[] { });

            // zero test (0) [0]
            RunTest(new int[] { 0 }, new int[] { 0 });

            // single empty test (21) [1, 2]
            RunTest(new int[] { }, new int[] { 1, 2 });

            // zero in digit test (43) [3, 4]
            RunTest(new int[] { 0, 2 }, new int[] { 3, 2 });

            // mismatch array length (26) [6, 2]
            RunTest(new int[] { 2 }, new int[] { 4, 2 });

            // easy example (807) [7, 0, 8]
            RunTest(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 });

            // carry example (1,320) [0, 2, 3, 1]
            RunTest(new int[] { 9, 8, 7 }, new int[] { 1, 3, 5 });

            // leet example two (10,009,998) [8,9,9,9,0,0,0,1]
            RunTest(new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9 });
        }

        public static void RunTest(int[] nums1, int[] nums2)
        {
            var head1 = GetExample(nums1);
            var head2 = GetExample(nums2);
            AddTwoNumbers(head1, head2);
        }

        public static void AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var start = DateTime.Now;

            ListNode headNode = null;
            ListNode priorNode = null;
            ListNode currentNode = null;

            int carry = 0;

            while (l1 != null || l2 != null)
            {
                var value = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;

                carry = 0;
                if (value >= 10)
                {
                    carry = 1;
                    value -= 10;
                }

                currentNode = new ListNode(value, null);
                if (priorNode != null)
                {
                    priorNode.next = currentNode;
                }

                if (headNode == null)
                {
                    headNode = currentNode;
                }

                priorNode = currentNode;

                if (l1 != null)
                {
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    l2 = l2.next;
                }
            }

            if (carry > 0)
            {
                currentNode = new ListNode(carry, null);
                priorNode.next = currentNode;
            }

            var timeSpan = DateTime.Now.Subtract(start).TotalMilliseconds;
            PrintNodes(headNode, timeSpan);
        }

        private static ListNode GetExample(int[] nums)
        {
            ListNode head = null;
            ListNode last = null;

            foreach (var num in nums)
            {
                var node = new ListNode(num);

                if (last != null)
                {
                    last.next = node;
                }

                if (head == null)
                {
                    head = node;
                }

                last = node;
            }

            // PrintNodes(head);

            return head;
        }

        private static void PrintNodes(ListNode head, double? totalMs = null)
        {
            var values = string.Empty;

            ListNode current = head;
            while (current != null)
            {
                values += current.val + ",";
                current = current.next;
            }

            Console.WriteLine($"{totalMs} {values}");
        }
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
