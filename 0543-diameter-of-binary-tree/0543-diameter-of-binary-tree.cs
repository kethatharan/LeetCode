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
    int max=0;
    public int DiameterOfBinaryTree(TreeNode root) {
        Func(root);
        return max;
    }

    int Func(TreeNode root){
        if(root==null){
            return 0;
        }
        int leftD=Func(root.left);
        int rightD=Func(root.right);
        max=Math.Max(max,leftD+rightD);
        return Math.Max(leftD,rightD)+1;
    }
}