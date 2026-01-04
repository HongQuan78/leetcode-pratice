public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        k %= nums.Length;

        if (nums.Length <= 1 || k == 0)
        {
            return;
        }

        int left = 0;
        int right = nums.Length - 1;
        Reverse(left, right, nums);

        left = 0;
        right = k - 1;
        Reverse(left, right, nums);

        left = k;
        right = nums.Length - 1;
        Reverse(left, right, nums);
    }

    public void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public void Reverse(int left, int right, int[] nums)
    {
        while (left < right)
        {
            Swap(ref nums[left], ref nums[right]);
            left++;
            right--;
        }
    }
}
