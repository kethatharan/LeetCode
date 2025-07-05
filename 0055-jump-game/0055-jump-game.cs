public class Solution {
    public bool CanJump(int[] nums) {
        int n=nums.Length;
        int target=n-1;
        for(int i=n-1;i>=0;i--){
            if((i+nums[i])>=target){
                target=i;
            }
        }
        if(target==0){
            return true;
        }else{
            return false;
        }
        
    }
}