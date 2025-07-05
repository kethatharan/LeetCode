public class Solution {
    public int Candy(int[] ratings) {
        int[] can=new int[ratings.Length];
        for(int i=0;i<ratings.Length;i++){
            can[i]=1;
        }
        for(int i=1;i<ratings.Length;i++){
            if(ratings[i]>ratings[i-1]){
                can[i]=can[i-1]+1;
            }
        }
        for(int i=ratings.Length-2;i>=0;i--){
            if(ratings[i]>ratings[i+1]){
                can[i]=Math.Max(can[i],can[i+1]+1);
                
            }
        }
        int sum=0;
        foreach(var c in can){
            sum+=c;
        }
        return sum;
    }
}