/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<string> BinaryTreePaths(TreeNode root) {
        List<string> ans=new();
        Func(root,"",ans);
        return ans;
    }

    void Func(TreeNode root,string path,List<string> ans){
        if(root!=null){
            path+=root.val;
            if(root.left==null&&root.right==null){
                ans.Add(path);
            }
            path+="->";
            Func(root.left,path,ans);
            Func(root.right,path,ans);
        }
    }
}