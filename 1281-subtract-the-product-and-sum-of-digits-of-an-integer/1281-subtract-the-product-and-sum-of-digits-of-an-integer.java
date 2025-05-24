class Solution {
    public int subtractProductAndSum(int n) {
        int mul=1;
      int sum=0;
		do{
                 int temp=n%10;
                 mul*=temp;
                 sum+=temp;
                 n/=10;
            }while(n>0);
            return mul-sum;
    }
}