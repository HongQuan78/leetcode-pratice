public class Solution
{
    class Event
    {
        public double y;
        public int l;
        public int r;
        public int type;

        public Event(double y, int l, int r, int type)
        {
            this.y = y;
            this.l = l;
            this.r = r;
            this.type = type;
        }
    }

    class SegTree
    {
        int[] cnt;
        double[] len;
        double[] xs;

        public SegTree(double[] xs)
        {
            this.xs = xs;
            int n = xs.Length * 4;
            cnt = new int[n];
            len = new double[n];
        }

        public void Update(int node, int l, int r, int ql, int qr, int v)
        {
            if (qr <= l || r <= ql)
            {
                return;
            }

            if (ql <= l && r <= qr)
            {
                cnt[node] += v;
                PushUp(node, l, r);
                return;
            }

            int m = (l + r) / 2;
            Update(node * 2, l, m, ql, qr, v);
            Update(node * 2 + 1, m, r, ql, qr, v);
            PushUp(node, l, r);
        }

        void PushUp(int node, int l, int r)
        {
            if (cnt[node] > 0)
            {
                len[node] = xs[r] - xs[l];
            }
            else
            {
                if (r - l == 1)
                {
                    len[node] = 0;
                }
                else
                {
                    len[node] = len[node * 2] + len[node * 2 + 1];
                }
            }
        }

        public double Query()
        {
            return len[1];
        }
    }

    public double SeparateSquares(int[][] squares)
    {
        List<double> xsList = new List<double>();
        foreach (var s in squares)
        {
            xsList.Add(s[0]);
            xsList.Add(s[0] + s[2]);
        }

        xsList.Sort();
        double[] xs = xsList.Distinct().ToArray();

        Dictionary<double, int> idx = new Dictionary<double, int>();
        for (int i = 0; i < xs.Length; i++)
        {
            idx[xs[i]] = i;
        }

        List<Event> events = new List<Event>();
        foreach (var s in squares)
        {
            double x = s[0];
            double y = s[1];
            double l = s[2];

            int L = idx[x];
            int R = idx[x + l];

            events.Add(new Event(y, L, R, 1));
            events.Add(new Event(y + l, L, R, -1));
        }

        events.Sort((a, b) => a.y.CompareTo(b.y));

        SegTree st = new SegTree(xs);
        double total = 0;
        double prevY = events[0].y;

        foreach (var e in events)
        {
            double dy = e.y - prevY;
            if (dy > 0)
            {
                total += dy * st.Query();
                prevY = e.y;
            }

            st.Update(1, 0, xs.Length - 1, e.l, e.r, e.type);
        }

        double half = total / 2.0;
        st = new SegTree(xs);
        prevY = events[0].y;
        double cur = 0;

        foreach (var e in events)
        {
            double dy = e.y - prevY;
            double len = st.Query();

            if (dy > 0)
            {
                if (cur + dy * len >= half)
                {
                    return prevY + (half - cur) / len;
                }

                cur += dy * len;
                prevY = e.y;
            }

            st.Update(1, 0, xs.Length - 1, e.l, e.r, e.type);
        }

        return prevY;
    }
}
