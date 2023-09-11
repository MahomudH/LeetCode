using System;

namespace LeetCode.Easy;

public class MajorityElement
{
    public static int GetMajorityElement(int[] nums)
    {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        int majorityCount = nums.Length / 2;

        foreach (int num in nums)
        {
            if (!counts.ContainsKey(num))
            {
                counts[num] = 1;
            }
            else
            {
                counts[num]++;
            }

            // Check if the current number has become the majority element.
            if (counts[num] > majorityCount)
            {
                return num;
            }
        }

        throw new InvalidOperationException("No majority element found.");
    }
}

