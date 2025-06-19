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
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists.Length==0){
            return null;
        }
        if(lists.Length==1){
            return lists[0];
        }
        ListNode merged=merge_two(lists[0],lists[1]);
        for(int i=2;i<lists.Length;i++){
            merged=merge_two(merged,lists[i]);
        }
        return merged;
    }

    public ListNode merge_two(ListNode l1,ListNode l2){
        ListNode dummy=new ListNode();
        ListNode temp=dummy;
        while(l1!=null&&l2!=null){
            if(l1.val<=l2.val){
                temp.next=l1;
                temp=temp.next;
                l1=l1.next;
            }else{
                temp.next=l2;
                temp=temp.next;
                l2=l2.next;
            }
        }
        if(l1!=null){
            temp.next=l1;
        }
        if(l2!=null){
            temp.next=l2;
        }
        return dummy.next;
    }
}