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
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        IList<IList<int>> ans=new List<IList<int>>();
        List<int> path=new();
        Func(root,0,ans,targetSum,path);
        return ans;
    }

    void Func(TreeNode root, int sum,IList<IList<int>> ans,int target,List<int> path){
        if(root==null){
            return;
        }
        path.Add(root.val);
        sum+=root.val;
        if(root.left==null&&root.right==null){
            if(sum==target){
                ans.Add(new List<int>(path));
            }
        }
        Func(root.left,sum,ans,target,path);
        Func(root.right,sum,ans,target,path);
        path.RemoveAt(path.Count - 1);
    }
}