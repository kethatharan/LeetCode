class Solution {
    public int[] findOrder(int numCourses, int[][] prerequisites) {
        int V=numCourses;
        List<List<Integer>> ans=new ArrayList<>();
        for(int i=0;i<V;i++){
            ans.add(new ArrayList<>());
        }
        int m=prerequisites.length;
        int[] ind =new int[V];
        for(int i=0;i<m;i++){
            int u=prerequisites[i][0];
            int v=prerequisites[i][1];
            ans.get(v).add(u);
            ind[u]++;
        }
        Queue<Integer> q=new LinkedList<>();
        for(int i=0;i<V;i++){
            if(ind[i]==0){
                q.offer(i);
            }
        }
        int[] ansi=new int[V];
        int count=0;
        while(!q.isEmpty()){
            int curr=q.poll();
            ansi[count]=curr;
            count++;
            for(int n:ans.get(curr)){
                ind[n]--;
                if(ind[n]==0){
                    q.offer(n);
                }
            }
        }
        if(count == numCourses){
            return ansi;
        }else return new int[] {};
    }
}