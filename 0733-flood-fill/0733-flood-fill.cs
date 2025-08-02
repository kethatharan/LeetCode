public class Solution {
    public int[][] FloodFill(int[][] grid, int sr, int sc, int color) {
        
        int ans=0;
        int r=grid.Length;
        int c=grid[0].Length;
        int old=grid[sr][sc];
        if(old!=color){
        DFS(grid,sr,sc,r,c,old,color);
        }
        return grid;
    }

    public void DFS(int[][] grid, int i,int j,int r, int c,int old,int color){
        if(i<0||j<0||i>=r||j>=c||grid[i][j]!=old){
            return;
        }
        grid[i][j]=color;
        DFS(grid,i,j+1,r,c,old,color);
        DFS(grid,i+1,j,r,c,old,color);
        DFS(grid,i,j-1,r,c,old,color);
        DFS(grid,i-1,j,r,c,old,color);
    }
    
}