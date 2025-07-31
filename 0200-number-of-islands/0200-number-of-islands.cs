public class Solution {
    public int NumIslands(char[][] grid) {
        int ans=0;
        int r=grid.Length;
        int c=grid[0].Length;
        for(int i=0;i<r;i++){
            for(int j=0;j<c;j++){
                if(grid[i][j].Equals('1')){
                    DFS(grid,i,j,r,c);
                    ans++;
                }
            }
        }
        return ans;
    }

    public void DFS(char[][] grid, int i,int j,int r, int c){
        if(i<0||j<0||i>=r||j>=c||grid[i][j].Equals('0')){
            return;
        }
        grid[i][j]='0';
        DFS(grid,i,j+1,r,c);
        DFS(grid,i+1,j,r,c);
        DFS(grid,i,j-1,r,c);
        DFS(grid,i-1,j,r,c);
    }
}