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
    public IList<int> PostorderTraversal(TreeNode root) {
        Postorder(root);
        return ans;
    }

    void Postorder(TreeNode root){
        if(root==null){
            return;
        }
        Postorder(root.left);
        Postorder(root.right);
        ans.Add(root.val);
    }
}