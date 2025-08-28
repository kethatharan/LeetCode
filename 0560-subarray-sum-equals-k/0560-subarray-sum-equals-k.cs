public class Solution {
    public int SubarraySum(int[] nums, int k) {
        Dictionary<int,int> dict=new Dictionary<int,int>();
        dict[0]=1;
        int count =0;
        int num=0;
        foreach(var n in nums){
            num+=n;
            if(dict.ContainsKey(num-k)){
                count+=dict[num-k];
            }
            dict[num]=dict.GetValueOrDefault(num,0)+1;
        }
        return count;
    }
}