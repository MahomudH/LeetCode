namespace LeetCode.Easy;

public class AllNumbersDisappearedInArray
{
    public static int[] FindAllNumbersDisappearInArray(int[] nums)
    {
        int val;
        int length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            val = Math.Abs(nums[i]) - 1;
            nums[val] = -Math.Abs(nums[val]);
        }

        List<int> result = new List<int>();
        for (int i = 0; i < length; i++)
        {
            if (nums[i] > 0)
                result.Add(i+1);
        }

        return result.ToArray();
    }
}

