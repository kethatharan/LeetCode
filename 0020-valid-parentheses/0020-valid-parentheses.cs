public class Solution {
    public bool IsValid(string s) {
        Stack<char> st=new();
        foreach(var c in s.ToCharArray()){
            if(c=='{'||c=='['||c=='('){
                st.Push(c);
            }else{
                if(st.Count() == 0){
                    return false;
                }else if((c=='}'&&st.Peek()!='{')||(c==']'&&st.Peek()!='[')||(c==')'&&st.Peek()!='(')){
                    return false;
                }else{
                    st.Pop();
                }
            }
        }
        if(st.Count() == 0){
            return true;
        }else{
            return false;
        }
    }
}