public class Solution
{
    public int MaximizeSquareHoleArea(int n, int m, int[] hBars, int[] vBars)
    {
        int maxH = GetMax(hBars);
        int maxV = GetMax(vBars);

        int side = Math.Min(maxH, maxV) + 1;
        return side * side;
    }

    private int GetMax(int[] bars)
    {
        if (bars.Length == 0)
        {
            return 0;
        }

        Array.Sort(bars);

        int max = 1;
        int cur = 1;

        for (int i = 1; i < bars.Length; i++)
        {
            if (bars[i] == bars[i - 1] + 1)
            {
                cur++;
            }
            else
            {
                max = Math.Max(max, cur);
                cur = 1;
            }
        }

        return Math.Max(max, cur);
    }
}
