public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int counter = 1;
        int candidate = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == candidate)
            {
                counter++;
                continue;
            }

            if (counter == 0)
            {
                candidate = nums[i];
                counter = 1;
                continue;
            }

            counter--;
        }
        return candidate;
    }
}
