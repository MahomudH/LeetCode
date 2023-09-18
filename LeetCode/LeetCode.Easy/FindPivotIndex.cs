namespace LeetCode.Easy;

public class FindPivotIndex
{
    public static int GetPivotIndex(int[] nums)
    {
        int total = 0;
        foreach (int i in nums)
        {
            total += i;
        }

        int leftSum = 0;
        for (int i = 0, length = nums.Length; i < length; i++)
        {
            int rightSum = total - leftSum - nums[i];
            if (leftSum == rightSum)
                return i;

            leftSum += nums[i]; 
        }
        return -1;
    }
}

