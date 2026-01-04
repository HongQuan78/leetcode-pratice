public class Solution
{
    public int SumFourDivisors(int[] nums)
    {
        int result = 0;
        foreach (int number in nums)
        {
            int count = 2;
            int sumDivisor = number + 1;
            int limit = (int)Math.Sqrt(number);
            for (int i = 2; i <= limit; i++)
            {
                if (number % i == 0)
                {
                    sumDivisor += i;
                    count++;
                    if (i * i != number)
                    {
                        sumDivisor += number / i;
                        count++;
                    }
                }
                if (count > 4)
                {
                    break;
                }
            }
            if (count == 4)
            {
                result += sumDivisor;
            }
        }
        return result;
    }
}
