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
    public ListNode RotateRight(ListNode head, int k) {
        if(head==null||head.next==null||k==0){
            return head;
        }
        ListNode curr=head;
        int len=1;
        while(curr.next!=null){
            len++;
            curr=curr.next;
        }
        curr.next=head;
        k=k%len;
        k=len-k;
        while(k>0){
            curr=curr.next;
            k--;
        }
        head=curr.next;
        curr.next=null;
        return head;
    }
}