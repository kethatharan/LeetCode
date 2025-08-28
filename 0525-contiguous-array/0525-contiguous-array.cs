public class Solution {
    public int FindMaxLength(int[] nums) {
        Dictionary<int,int> dict=new Dictionary<int,int>();
        dict[0]=-1;
        int sum=0;int max=0;
        for(int i=0;i<nums.Length;i++){
            sum+=nums[i]==1?1:-1;
            if(dict.ContainsKey(sum)){
                max=Math.Max(max,i-dict[sum]);
            }else{
                dict.Add(sum,i);
            }
        }
        return max;
    }
}