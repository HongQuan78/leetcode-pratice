public class Solution
{
    public int MaxDotProduct(int[] nums1, int[] nums2)
    {
        int n = nums1.Length;
        int m = nums2.Length;
        int[,] dp = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                int product = nums1[i] * nums2[j];
                int best = product;

                if (i > 0 && j > 0)
                {
                    best = Math.Max(best, dp[i - 1, j - 1] + product);
                }

                if (i > 0)
                {
                    best = Math.Max(best, dp[i - 1, j]);
                }
                if (j > 0)
                {
                    best = Math.Max(best, dp[i, j - 1]);
                }

                dp[i, j] = best;
            }
        }

        return dp[n - 1, m - 1];
    }
}
