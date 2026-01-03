public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0 || (x % 10 == 0 && x != 0))
        {
            return false;
        }
        if (x >= 0 && x <= 9)
        {
            return true;
        }

        int divisor = 1;
        while (x / divisor >= 10)
        {
            divisor *= 10;
        }

        int left = 0;
        int right = 0;
        while (divisor >= 10)
        {
            left = x / divisor;
            right = x % 10;
            if (left != right)
            {
                return false;
            }

            x = x % divisor;
            x = x / 10;
            divisor /= 100;
        }

        return true;
    }
}
