public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int start=0;
        int co=gas.Length;
        for(int i=0;i<co;i++){
            if(gas[i]>cost[i]){
                start=i;
                break;
            }
        }
        int tank=0;
        for(int i=start;i<co;i++){
            tank=(tank+gas[i])-cost[i];
            
        }
        for(int i=0;i<start;i++){
            Console.WriteLine(tank+"t");
            Console.WriteLine(gas[i]);
            Console.WriteLine(cost[i]);
           
            tank=(tank+gas[i])-cost[i];
        }
        if(tank==0){
        return start;
        }else{
            return tank;
        }
        //return -1;
    }
}