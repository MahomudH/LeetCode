

using System.Globalization;using System.Text.Json.Serialization.Metadata;

namespace MaximumSubarray
{
    public class MaxSubrray
    {
        public static int MaxSubArray(List<int> nums)
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

