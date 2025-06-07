class Solution {
    public int numSpecial(int[][] input) {
     int m=input.length;
     int n=input[0].length;
     int magic=0;
     for(int i=0;i<m;i++){
          for(int j=0;j<n;j++){
               if(input[i][j]==1){
                    if(IsValid(input,i,j)){
                         magic++;
                    }
               }
          }
     }
     return magic;   
    }

    public static boolean IsValid(int[][] input,int row,int col){
     
          for(int i=0;i<input[0].length;i++){
               if(col!=i&&input[row][i]==1){
                    return false;
               }
          }

          for(int i=0;i<input.length;i++){
               if(row!=i&&input[i][col]==1){
                    return false;
               }
          }
          return true;
    }
}