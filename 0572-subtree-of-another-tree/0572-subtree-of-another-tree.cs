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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        return Fun(root,subRoot);
    }
    bool Fun(TreeNode root,TreeNode sub){
        if(root==null){
            return false;
        }
        if(Func(root,sub)){
            return true;
        }
        return Fun(root.left,sub)||Fun(root.right,sub);
    }

    bool Func(TreeNode root,TreeNode sub){
        if(root==null&&sub==null){
            return true;
        }
        if(root==null||sub==null){
            return false;
        }
        
        if(root.val!=sub.val){
            return false;
        }
        return Func(root.left,sub.left)&&Func(root.right,sub.right);
    }
}