class Solution {
    public int longestPalindromeSubseq(String s) {
        int m=s.length();
       int n=s.length();
       StringBuilder stringBuilder = new StringBuilder(s);
        stringBuilder.reverse();
        String r = stringBuilder.toString();
       int ans=0;
       int[][] dp=new int[m+1][n+1];
       for(int i=1;i<m+1;i++){
        for(int j=1;j<n+1;j++){
            
            if(s.charAt(i-1)==r.charAt(j-1)){
                dp[i][j]=1+dp[i-1][j-1];
            }else{
                dp[i][j]=Math.max(dp[i-1][j],dp[i][j-1]);
            }
        }
       }
       return dp[m][n];
    }
}