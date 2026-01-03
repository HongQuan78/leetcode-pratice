public class Solution
{
    public int RepeatedNTimes(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (i + 1 < nums.Length && nums[i] == nums[i + 1])
            {
                return nums[i];
            }

            if (i + 2 < nums.Length && nums[i] == nums[i + 2])
            {
                return nums[i];
            }

            if (i + 3 < nums.Length && nums[i] == nums[i + 3])
            {
                return nums[i];
            }
        }
        return 0;
    }
}
