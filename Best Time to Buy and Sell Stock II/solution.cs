public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int totalProfit = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] > prices[i - 1])
            {
                totalProfit += prices[i] - prices[i - 1];
            }
        }
        return totalProfit;
    }
}
