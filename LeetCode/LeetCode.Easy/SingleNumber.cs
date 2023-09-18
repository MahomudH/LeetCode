namespace LeetCode.Easy;
public class SingleNumber
{
    public static int GetSingleNumberV1(int[] nums)
    {
        Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

        for (int i = 0, length = nums.Length; i < length; i++)
        {
            if (keyValuePairs.ContainsKey(nums[i]))
            {
                keyValuePairs[nums[i]]++;
            }
            else
            {
                keyValuePairs.Add(nums[i], 1);
            }
        }

        foreach (var item in keyValuePairs)
        {
            if (item.Value == 1)  return item.Key; 
        }
        return 0;
    }

    public static int GetSingleNumberV2(int[] nums)
    {
        int result = 0;
        foreach (int number in nums)
        {
            result ^= number;
        }

        return result;
    }
}

