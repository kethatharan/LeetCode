public class Solution {
    int ans=0;
    public int MaxAreaOfIsland(int[][] grid) {
        int r=grid.Length;
        int c=grid[0].Length;
        int max=0;
        for(int i=0;i<r;i++){
            for(int j=0;j<c;j++){
                if(grid[i][j].Equals(1)){
                    DFS(grid,i,j,r,c);
                    max=Math.Max(ans,max);
                    ans=0;
                }
            }
        }
        return max;
    }

    public void DFS(int[][] grid, int i,int j,int r, int c){
        if(i<0||j<0||i>=r||j>=c||grid[i][j]==0){
            return;
        }
        ans++;
        grid[i][j]=0;
        DFS(grid,i,j+1,r,c);
        DFS(grid,i+1,j,r,c);
        DFS(grid,i,j-1,r,c);
        DFS(grid,i-1,j,r,c);
    }
}