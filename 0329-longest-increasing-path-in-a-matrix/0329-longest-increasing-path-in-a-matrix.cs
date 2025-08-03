public class Solution {
    public int LongestIncreasingPath(int[][] matrix) {
        int r=matrix.Length;
        int c=matrix[0].Length;
        int[][] res = new int[r][];
        for (int i = 0; i < r; i++) {
            res[i] = new int[c];
        }
        int ans=0;
        for(int i=0;i<r;i++){
            for(int j=0;j<c;j++){
                ans=Math.Max(ans,DFS(matrix,res,i,j,r,c));
            }
        }
        return ans;
    }

    public int DFS(int[][] mat,int[][] res, int i,int j,int r,int c){
        if (res[i][j] != 0)
        return res[i][j];

        int val=mat[i][j];
        int max=0;
        if(i>0&&mat[i-1][j]>val){
            max=Math.Max(max,DFS(mat,res,i-1,j,r,c));
        }
        if(j>0&&mat[i][j-1]>val){
            max=Math.Max(max,DFS(mat,res,i,j-1,r,c));
        }
        if(i<r-1&&mat[i+1][j]>val){
            max=Math.Max(max,DFS(mat,res,i+1,j,r,c));
        }
        if(j<c-1&&mat[i][j+1]>val){
            max=Math.Max(max,DFS(mat,res,i,j+1,r,c));
        }
        res[i][j] = max + 1;
           return res[i][j]; 
    }
}