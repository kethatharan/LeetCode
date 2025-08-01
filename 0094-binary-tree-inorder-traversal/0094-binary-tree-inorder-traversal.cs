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
    public IList<int> InorderTraversal(TreeNode root) {
        Inorder(root);
        return ans;
    }
    void Inorder(TreeNode root){
        if(root==null){
            return;
        }
        Inorder(root.left);
        ans.Add(root.val);
        Inorder(root.right);
    }
}