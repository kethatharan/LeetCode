public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int start=0;
        int co=gas.Length;
        int ga=0;
        int cos=0;
        for(int i=0;i<co;i++){
            ga+=gas[i];
            cos+=cost[i];
        }
        if(cos>ga){
            return -1;
        }
        int avail=0;
        int ind=0;
        for(int i=0;i<co;i++){
            avail=(avail+gas[i])-cost[i];
            if(avail<0){
                ind=i+1;
                avail=0;
            }
        }
        return ind;
    }
}