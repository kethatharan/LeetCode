public class NumArray {
    int[] sum;
    public NumArray(int[] nums) {
        int i=0;
        sum=new int[nums.Length];
        int temp=0;
        foreach(int n in nums){
            temp+=n;
            sum[i]=temp;
            i++;
        }
    }
    
    public int SumRange(int left, int right) {
        if(left==0){
            return sum[right];
        }
        else{
            return sum[right]-sum[left-1];
        }
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */