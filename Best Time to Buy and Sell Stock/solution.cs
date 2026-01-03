public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int buyValue = int.MaxValue;
        int bestProfit = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < buyValue)
            {
                buyValue = prices[i];
            }

            if (prices[i] - buyValue > bestProfit)
            {
                bestProfit = prices[i] - buyValue;
            }
        }

        return bestProfit;
    }
}
