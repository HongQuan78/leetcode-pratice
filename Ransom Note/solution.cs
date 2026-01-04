public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        int[] characters = new int[26];

        foreach (char c in magazine)
        {
            int index = c - 'a';
            characters[index]++;
        }

        foreach (char c in ransomNote)
        {
            int index = c - 'a';
            characters[index]--;

            if (characters[index] < 0)
            {
                return false;
            }
        }

        return true;
    }
}
