public class Solution {
    public int MinimumDeleteSum(string s1, string s2) {
        int m = s1.Length;
        int n = s2.Length;

        int[] dp = new int[n + 1];
        
        for(int i = 1; i <= m; i++)
        {
            int prev = 0;
            for(int j = 1; j <= n; j++)
            {
                int temp = dp[j];
                if(s1[i - 1] == s2[j - 1])
                {
                    dp[j] = prev + s1[i -1];
                }
                else
                {
                    dp[j] = Math.Max(dp[j], dp[j - 1]);
                }
                prev = temp;
            }
        }

        int sum1 = SumAscii(s1);
        int sum2 = SumAscii(s2);

        return sum1 + sum2 - 2 * dp[n];

    }

    private int SumAscii(string s)
    {   
        int sum = 0; 
        foreach(char c in s)
        {
            sum += c;
        }

        return sum;
    }
}