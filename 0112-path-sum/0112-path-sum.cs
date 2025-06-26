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
    
    public bool HasPathSum(TreeNode root, int targetSum) {
        return Func(root,0,targetSum);
    }
    bool Func(TreeNode root,int sum,int target){
        if(root==null){
            return false;
            }
            sum+=root.val;
        if(root.left==null&&root.right==null){
            return sum==target;
        }
        return Func(root.left,sum,target)||Func(root.right,sum,target);
    }
}