public class Solution {
    public int Rob(int[] nums) {
        int n=nums.Length;
        if(n==0) return 0;
        if(n==1) return nums[0];
        int[] dp = new int[n];
        dp[0]=nums[0];
        dp[1]=Math.Max(nums[0],nums[1]);
        for(int i=2;i<n;i++){
            int temp=nums[i]+dp[i-2];
            dp[i]=Math.Max(temp,dp[i-1]);
        }
        return dp[n-1];
    }
}