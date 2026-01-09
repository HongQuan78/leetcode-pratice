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
    public TreeNode SubtreeWithAllDeepest(TreeNode root) {
        return DepthFirstSearch(root).node;
    }

    private (int depth, TreeNode node) DepthFirstSearch(TreeNode root)
        {
            if(root == null)
            {
                return (0, null);
            }

            (int depth, TreeNode node) left = DepthFirstSearch(root.left);
            (int depth, TreeNode node) right = DepthFirstSearch(root.right);

            if (left.depth > right.depth)
            {
                return (left.depth + 1, left.node);
            } 
            else if(right.depth > left.depth)
            {
                return (right.depth + 1, right.node);
            }

            return (left.depth + 1, root);
        }
}