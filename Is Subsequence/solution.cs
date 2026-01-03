public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if (s == null || s.Length == 0)
        {
            return true;
        }
        if (t == null)
        {
            return false;
        }
        int counter = 0;
        for (int i = 0; i < t.Length; i++)
        {
            if (counter == s.Length)
            {
                break;
            }
            if (t[i] == s[counter])
            {
                counter++;
            }
        }

        return counter == s.Length;
    }
}
