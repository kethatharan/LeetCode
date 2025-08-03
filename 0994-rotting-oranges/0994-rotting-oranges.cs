public class Solution {
    public int OrangesRotting(int[][] grid) {
        int r=grid.Length;
        int c=grid[0].Length;
        int fresh=0;int rotten=0;
        Queue<(int, int)> q = new Queue<(int, int)>();
        for(int i=0;i<r;i++){
            for(int j=0;j<c;j++){
                if(grid[i][j]==2){
                    rotten++;
                    q.Enqueue((i,j));
                }
                if(grid[i][j]==1){
                    fresh++;
                }
            }
        }
        if(fresh==0){
            return 0;
        }
        int minute=0;
        List<int> dx=new(){1,0,-1,0};
        List<int> dy=new(){0,1,0,-1};
        while(q.Count>0){
            int size=q.Count;
            for(int i=0;i<size;i++){
                var (x0, y0) = q.Dequeue();
                for(int j=0;j<4;j++){
                    int x=x0+dx[j];
                    int y=y0+dy[j];
                    if(x>=0&&y>=0&&x<r&&y<c&&grid[x][y]==1){
                        grid[x][y]=2;
                        q.Enqueue((x,y));
                        fresh--;
                    }
                }
            }
            if(q.Count>0){
                minute++;
            }
        }
        if(fresh==0){
            return minute;
        }
        return -1;
    }
}