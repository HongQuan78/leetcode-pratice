public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int lastIndex = digits.Length - 1;
        while (lastIndex >= 0)
        {
            if (digits[lastIndex] < 9)
            {
                digits[lastIndex] += 1;
                return digits;
            }
            if (digits[lastIndex] == 9)
            {
                digits[lastIndex] = 0;
                lastIndex--;
                continue;
            }

            digits[lastIndex] += 1;
            break;
        }

        int[] result = new int[digits.Length + 1];
        result[0] = 1;
        return result;
    }
}
