public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> sub = new Dictionary<char, int>();
        foreach(var chr in s.ToCharArray()){
            if(sub.ContainsKey(chr)){
                sub[chr]+=1;
            }else{
                sub.Add(chr,1);
            }
        }
        foreach(var ta in t.ToCharArray()){
            if(sub.ContainsKey(ta)){
                sub[ta]-=1;
            }else{
                return false;
            }
        }
        foreach(var sa in sub){
            if(sa.Value!=0){
                return false;
            }
        }
        return true;
    }
}