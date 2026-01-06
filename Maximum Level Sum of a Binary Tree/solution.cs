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
public class Solution
{
    public int MaxLevelSum(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        if (root.left == null && root.right == null)
        {
            return 1;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        int currentLevel = 0;
        int bestLevel = 1;
        long maxSum = long.MinValue;

        while (queue.Count > 0)
        {
            currentLevel++;
            int nodes = queue.Count;
            long currentSum = 0;
            while (nodes > 0)
            {
                nodes--;
                TreeNode node = queue.Dequeue();
                currentSum += node.val;

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                bestLevel = currentLevel;
            }
        }
        return bestLevel;
    }
}
