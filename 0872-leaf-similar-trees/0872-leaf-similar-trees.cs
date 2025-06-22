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
    List<int> root1Leaf=new();
    List<int> root2Leaf=new();
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        GetLeafNodes(root1Leaf,root1);
        GetLeafNodes(root2Leaf,root2);
        return Enumerable.SequenceEqual(root1Leaf, root2Leaf);
    }

        void GetLeafNodes(List<int> list,TreeNode root){
            if(root==null){
                return ;
            }
            if(root.left==null&&root.right==null){
                list.Add(root.val);
            }
            GetLeafNodes(list,root.left);
            GetLeafNodes(list,root.right);
        }
}