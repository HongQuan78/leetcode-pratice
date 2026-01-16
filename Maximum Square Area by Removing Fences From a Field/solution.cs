public class Solution {
    public int MaximizeSquareArea(int m, int n, int[] hFences, int[] vFences) {
        List<int> h = hFences.ToList();
        h.Add(1);
        h.Add(m);
        
        List<int> v = vFences.ToList();
        v.Add(1);
        v.Add(n);
        
        HashSet<int> hDiffs = new HashSet<int>();
        for (int i = 0; i < h.Count; i++) {
            for (int j = 0; j < h.Count; j++) {
                if (i != j) {
                    hDiffs.Add(Math.Abs(h[i] - h[j]));
                }
            }
        }
        
        long maxSide = -1;
        for (int i = 0; i < v.Count; i++) {
            for (int j = 0; j < v.Count; j++) {
                if (i != j) {
                    int diff = Math.Abs(v[i] - v[j]);
                    if (hDiffs.Contains(diff)) {
                        maxSide = Math.Max(maxSide, diff);
                    }
                }
            }
        }
        
        if (maxSide == -1) return -1;
        
        return (int)((maxSide * maxSide) % 1000000007);
    }
}