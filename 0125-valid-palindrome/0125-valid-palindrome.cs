public class Solution {
    public bool IsPalindrome(string s) {
        s=s.ToLower();
        s=new string(s.Where(x=>char.IsLetterOrDigit(x)).ToArray());
        Console.WriteLine(s);
        return function(s,0);
    }
    
    public bool function(string s,int i){
        
        int n=s.Length;
        if(i>=n/2) return true;
        if(s[i]!=s[n-i-1]){
            return false;
        }
        i++;
        return function(s,i);
        
    }
}