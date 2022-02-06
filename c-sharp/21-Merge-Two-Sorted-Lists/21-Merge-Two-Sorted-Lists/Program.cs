

using _21_Merge_Two_Sorted_Lists;
/**
* Definition for singly-linked list.
* You are given the heads of two sorted linked lists list1 and list2.
* Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.
* Return the head of the merged linked list.
*/

var sln = new Solution();


sln.MergeTwoLists(null, sln.GetTestData(new int[] { 1, 2 }));
sln.MergeTwoLists(sln.GetTestData(new int[] { 1,2 }), null);
sln.MergeTwoLists(null, null);

sln.MergeTwoLists(sln.GetTestData(new int[] { 1, 3, 5 }), sln.GetTestData(new int[] { 2, 4, 8 }));
sln.MergeTwoLists(sln.GetTestData(new int[] { 1 }), sln.GetTestData(new int[] { 2, 4, 8 }));
sln.MergeTwoLists(sln.GetTestData(new int[] { 1, 3, 5 }), sln.GetTestData(new int[] { 2 }));

public class Solution {
    
    public ListNode MergeTwoLists(ListNode? list1, ListNode? list2) {

        var current = new ListNode();
        var head = current;

        while (list1 != null && list2 != null)
        {
            if(list1 == null)
            {
                current.val = list2.val;
                list2 = list2.next;
            }
            else if(list2 == null)
            {
                current.val = list1.val;
                list1 = list1.next;
            }
            else if (list1.val <= list2.val)
            {
                current.val = list1.val;
                list1 = list1.next;
            }
            else if (list2.val < list1.val)
            {
                current.val = list2.val;
                list2 = list2.next;
            }

            if (list1 != null && list2 != null)
            {
                current.next = new ListNode();
                current = current.next;
            }
        }

        return head;
    }

    public ListNode GetTestData(int[] vals)
    {
        var current = new ListNode();
        var head = current;

        foreach (var val in vals)
        {
            current.val = val;
            current.next  = new ListNode();
            current = current.next;
        }

        return head;
    }
}