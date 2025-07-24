public class TrieNode{
    public bool is_word;
    public TrieNode[] children;

    public TrieNode()
    {
        is_word = false;
        children = new TrieNode[26];
    }
}

public class Trie {

private TrieNode root;
    public Trie() {
        root= new TrieNode();
    }

    public void Insert(string word) {
        int k=0;
        TrieNode curr=root;
        for(int i=0;i<word.Length;i++){
            k=word[i]-'a';
            if(curr.children[k]==null){
                curr.children[k]=new TrieNode();
            }
            curr=curr.children[k];
        }
        curr.is_word=true;

    }
    
    public bool Search(string word) {
        int k=0;
        TrieNode curr=root;
        for(int i=0;i<word.Length;i++){
            k=word[i]-'a';
            curr=curr.children[k];
            if(curr==null){
                return false;
            }
        }
        if(curr.is_word==true){
            return true;
        }
        return false;
    }
    
    public bool StartsWith(string prefix) {
        int k=0;
        TrieNode curr=root;
        for(int i=0;i<prefix.Length;i++){
            k=prefix[i]-'a';
            curr=curr.children[k];
            if(curr==null){
                return false;
            }
        }
        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */