public class Solution {
    public int MinTimeToVisitAllPoints(int[][] points) {
        
        int totalTime = 0;

        for (int i = 0; i < points.Length - 1; i++)
        {
            int dx = Math.Abs(points[i + 1][0] - points[i][0]);
            int dy = Math.Abs(points[i + 1][1] - points[i][1]);

            totalTime += Math.Max(dx, dy);
        }

        return totalTime;
    }
}