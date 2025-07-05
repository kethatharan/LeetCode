public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int co=gas.Length;
        int totG=0;
        int totC=0;
        int tank=0;
        int start=0;
        for(int i=0;i<co;i++){
            tank=(tank+gas[i])-cost[i];
            if(tank<0){
                start=i+1;
                tank=0;
            }
            totG+=gas[i];
            totC+=cost[i];
        }
        if(totC>totG){
            return -1;
        }
        return start;
    }
}