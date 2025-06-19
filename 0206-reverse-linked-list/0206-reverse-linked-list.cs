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
    public ListNode ReverseList(ListNode head) {
        if(head==null){
            return head;
        }
        ListNode temp=head;
        ListNode Nnext=null;
        ListNode prev=null;
        while(temp!=null){
            Nnext=temp.next;
            temp.next=prev;
            prev=temp;
            temp=Nnext;
        }
        head=prev;
        return head;
    }
}