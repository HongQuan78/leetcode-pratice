public class Solution
{
    public int NumOfWays(int n)
    {
        long MOD = 1_000_000_007;
        long aba = 6;
        long abc = 6;

        for (int i = 2; i <= n; i++)
        {
            long prevAba = aba;
            long prevAbc = abc;

            long newAba = (3 * prevAba + 2 * prevAbc) % MOD;
            long newAbc = (2 * prevAba + 2 * prevAbc) % MOD;

            aba = newAba;
            abc = newAbc;
        }

        return (int)((aba + abc) % MOD);
    }
}
