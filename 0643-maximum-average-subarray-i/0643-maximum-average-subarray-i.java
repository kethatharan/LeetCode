class Solution {
    public double findMaxAverage(int[] nums, int k) {
        if(k>=nums.length){
            double tot=0;
            for(int n : nums){
                tot+=n;
            }
            return tot/k;
        }
        int tot=0;
        for(int i=0;i<k;i++){
            tot+=nums[i];
        }
        double max=(double)tot/k;
        int j=0;
        for(int i=k;i<nums.length;i++){
            tot=tot-nums[j]+nums[i];
            j++;
            max=Math.max(max,(double)tot/k);
        }
        return max;
    }
}