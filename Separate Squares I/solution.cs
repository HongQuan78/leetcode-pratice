public class Solution {
    public double SeparateSquares(int[][] squares) {
        double total = 0;
        double low = 1e9;
        double high = 0;

        foreach(var s in squares)
        {
            total += (double)s[2] * s[2];
            low = Math.Min(low, s[1]);
            high = Math.Max(high, s[1] + s[2]);
        }

        double half = total / 2;
        double eps = 1e-5;
        while (Math.Abs(high - low) > eps)
        {
            double mid = (low + high) / 2;
            double below = 0;

            foreach(var s in squares)
            {
                double y = s[1];
                double l = s[2];
                below += Math.Max(0, Math.Min(l, mid - y)) * l;
            }
            if(below >= half)
            {
                high = mid;
            }
            else
            {
                low = mid;
            }
        }
        return low;
    }

}
