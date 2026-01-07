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
    private const long MOD = 1_000_000_007;

    private long totalTreeSum;
    private long bestProduct;

    public int MaxProduct(TreeNode root)
    {
        totalTreeSum = CalculateSubtreeSum(root);
        bestProduct = 0;
        ComputeBestProduct(root);

        return (int)(bestProduct % MOD);
    }

    private long CalculateSubtreeSum(TreeNode node)
    {
        if (node == null)
        {
            return 0;
        }

        long leftSum = CalculateSubtreeSum(node.left);
        long rightSum = CalculateSubtreeSum(node.right);

        return node.val + leftSum + rightSum;
    }

    private long ComputeBestProduct(TreeNode node)
    {
        if (node == null)
        {
            return 0;
        }

        long leftSum = ComputeBestProduct(node.left);
        long rightSum = ComputeBestProduct(node.right);

        long subtreeSum = node.val + leftSum + rightSum;
        long otherPartSum = totalTreeSum - subtreeSum;
        long product = subtreeSum * otherPartSum;

        if (product > bestProduct)
        {
            bestProduct = product;
        }

        return subtreeSum;
    }
}
