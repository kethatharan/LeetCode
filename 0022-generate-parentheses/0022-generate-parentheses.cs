public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        List<String> strs=new();
        Helper(strs,0,0,n,"");
        return strs;
    }

    public void Helper(List<String> str,int open, int close,int n, String temp){
        if(open==close&&temp.Length==n*2){
            str.Add(temp);
            return;
        }
        if(open<n){
            Helper(str,open+1,close,n,temp+"(");
        }
        if(open>close){
            Helper(str,open,close+1,n,temp+")");
        }
    }
}