public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int start=0;
        int end=numbers.Length-1;
        int[] ans=new int[2];
        while(start<end){
            int sum=numbers[start]+numbers[end];
            if(sum==target){
                ans[0]=start+1;
                ans[1]=end+1;
                return ans;
            }else if(sum<target){
                start++;
            }else{
                end--;
            }
        }
        return new int[2]{-1,-1};
        
    }
}