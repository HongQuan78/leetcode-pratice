public class Solution
{
    public bool IsValid(string s)
    {
        if (s.Length == 0 || s.Length % 2 == 1)
        {
            return false;
        }

        Stack<char> parentheses = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            char currentChar = s[i];
            if (currentChar == '(' || currentChar == '{' || currentChar == '[')
            {
                parentheses.Push(s[i]);
                continue;
            }

            if (parentheses.Count == 0)
            {
                return false;
            }
            int diff = currentChar - parentheses.Peek();
            if (diff == 1 || diff == 2)
            {
                parentheses.Pop();
                continue;
            }

            return false;
        }

        return parentheses.Count == 0;
    }
}
