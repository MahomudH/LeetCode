namespace LeetCode.Easy
{
    public class RemoveElement
    {
        public static int RemoveElementFromArray(int[] nums,int val)
        {
            int pointer=0;

            for (int i = 0, length = nums.Length; i < length; i++)
            {
                if (nums[i] != val)
                {
                    nums[pointer] = nums[i];
                    pointer++;
                }
            }

            return pointer;
        }
    }
}
