public class Solution {
    public int NthUglyNumber(int n) {
        int digit=5;
        int i;
        if(n<=5){
            return n;
        }
        int d=0;
       for(i=6;digit!=n;i++){
            if(i%2==0||i%3==0||i%5==0){
                Console.WriteLine(i);
                digit++;
                d=i;
            }
       }
       return d;
    }
}