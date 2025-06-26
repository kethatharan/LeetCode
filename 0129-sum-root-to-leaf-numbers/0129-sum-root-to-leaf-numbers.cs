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
    public int SumNumbers(TreeNode root) {
        List<int> ans=new();
        int sum=0;
        var n=Func(root,sum);
        return n;
    }

    int Func(TreeNode root,int num){
        if(root==null){
            return 0;
        }
        else if(root!=null){
            num=num*10+root.val;
            if(root.left==null&&root.right==null){
                return num;
            }
        }
        return Func(root.left,num)+Func(root.right,num);
    }
}