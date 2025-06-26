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
    public int MaxDepth(TreeNode root) {
        int s=0;
        var sum=Func(root,s);
        return sum;
    }

    int Func(TreeNode root,int sum){
        if(root==null){
            return 0;
        }
        sum+=1;
        if(root.left==null&&root.right==null){
            return sum;
        }
        
        return Math.Max(Func(root.left,sum),Func(root.right,sum));
    }
}