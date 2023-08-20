namespace LeetCode.Medium
{
    public class MaximumSubarray
    {
        public static int GetMaxSubArray(List<int> nums)
        {
            int maxSub = nums[0];
            int curSum = 0;

            foreach (int num in nums)
            {
                if (curSum < 0)
                    curSum = 0;

                curSum += num;
                maxSub = Math.Max(maxSub, curSum);
            }

            return maxSub;
        }
    }
}
