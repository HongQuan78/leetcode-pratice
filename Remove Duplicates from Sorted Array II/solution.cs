public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length <= 2)
        {
            return nums.Length;
        }
        int count = 2;
        for (int i = 2; i < nums.Length; i++)
        {
            if (nums[i] != nums[count - 2])
            {
                nums[count] = nums[i];
                count++;
            }
        }

        return count;
    }
}
