class Solution {
    public int sumFourDivisors(int[] input) {
        int max=0;
     int k=0;int div=0;
        for(int i=0;i<input.length;i++){
          for(int j=1;j<=input[i];j++)
          {
               if(input[i]%j==0){
                    k+=j;
                    div++;
               }
               if(div>4){break;}
          }
          if(div==4){
            max+=k;
          }
          k=0;div=0;
        }
        return max;
    }
}