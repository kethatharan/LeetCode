public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var pq=new PriorityQueue<int,int>();
        foreach(var i in nums){
            pq.Enqueue(i,i);
            if(pq.Count>k){
                pq.Dequeue();
            }
        }
        return pq.Peek();
    }
}