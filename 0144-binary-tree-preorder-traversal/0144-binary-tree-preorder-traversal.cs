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
    List<int> ans=new();
    public IList<int> PreorderTraversal(TreeNode root) {
        Preorder(root);
        return ans;        
    }
    void Preorder(TreeNode root){
        if(root==null){
            return;
        }
        ans.Add(root.val);
        Preorder(root.left);
        Preorder(root.right);
    }
}