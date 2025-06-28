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
    public IList<int> RightSideView(TreeNode root) {
        Queue<TreeNode> q = new Queue<TreeNode>();
       var res = new List<int>();
       if (root == null) return res;
        q.Enqueue(root);
        while(q.Count > 0){
            int levelsize=q.Count;
            int temp = 0;
            for(int i=0;i<levelsize;i++){
                var element=q.Dequeue();
                temp =element.val;
                if(element.left!=null){
                    q.Enqueue(element.left);
                }
                if(element.right!=null){
                    q.Enqueue(element.right);
                }
            }
            res.Add(temp);
        }
        return res;
    }
}