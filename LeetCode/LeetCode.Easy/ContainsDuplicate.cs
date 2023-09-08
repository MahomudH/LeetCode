namespace LeetCode.Easy
{
    public class ContainsDuplicate
    {
        public static bool IsContainsDuplicateV1(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0, length = nums.Length; i < length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                    return true;

                dic.Add(nums[i], i);
            }
            return false;
        }

        public static bool IsContainsDuplicateV2(int[] nums)
        {
            HashSet<int> dic = new HashSet<int>();

            for (int i = 0, length = nums.Length; i < length; i++)
            {
                if (dic.Contains(nums[i]))
                    return true;

                dic.Add(nums[i]);
            }
            return false;
        }
    }
}
