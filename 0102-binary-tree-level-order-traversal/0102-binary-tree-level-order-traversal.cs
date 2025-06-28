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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        Queue<TreeNode> q = new Queue<TreeNode>();
       var res = new List<IList<int>>();
       if (root == null) return res;
        q.Enqueue(root);
        while(q.Count > 0){
            int levelsize=q.Count;
            List<int>temp = new();
            for(int i=0;i<levelsize;i++){
                var element=q.Dequeue();
                temp.Add(element.val);
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