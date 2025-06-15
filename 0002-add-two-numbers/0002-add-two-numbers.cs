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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
       ListNode dummy=new ListNode(0);
       ListNode temp=dummy;
       int carry=0;
       while(l1!=null||l2!=null||carry!=0){
        int sum=0;
        int valA = (l1 != null) ? l1.val : 0;
        int valB = (l2 != null) ? l2.val : 0;
        sum = valA + valB + carry;
        ListNode curr=new ListNode(sum%10);
        temp.next=curr;
        temp=temp.next;
        carry=sum/10;
        if (l1 != null) l1 = l1.next;
        if (l2 != null) l2 = l2.next;
       }
       return dummy.next;
    }
}