/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        // Merge into list 1

        ListNode head = new ListNode(0);
        ListNode tail = head;

        while(list1 != null && list2 != null)
        {
            if (list1.val >= list2.val)
            {
                // Insert list2 first
                tail.next = list2;
                list2 =  list2.next;
            }
            else
            {
                // Insert list1 first
                tail.next = list1;
                list1 = list1.next;
            }
            tail = tail.next;
        }

        if (list1 == null)
        {
            tail.next = list2;
        }
        else
        {
            tail.next = list1;
        }

        return head.next;
    }
}