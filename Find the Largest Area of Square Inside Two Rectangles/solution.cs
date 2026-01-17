public class Solution
{
    public long LargestSquareArea(int[][] bottomLeft, int[][] topRight)
    {
        int n = bottomLeft.Length;
        long best = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int lx = Math.Max(bottomLeft[i][0], bottomLeft[j][0]);
                int ly = Math.Max(bottomLeft[i][1], bottomLeft[j][1]);
                int rx = Math.Min(topRight[i][0], topRight[j][0]);
                int ry = Math.Min(topRight[i][1], topRight[j][1]);

                long w = rx - lx;
                long h = ry - ly;

                if (w <= 0 || h <= 0)
                {
                    continue;
                }

                long side = Math.Min(w, h);
                if (side > best)
                {
                    best = side;
                }
            }
        }

        return best * best;
    }
}
