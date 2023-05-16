namespace TwoSum
{
    public class TwoSum
    {
        public static int[] GetTwoSum(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                        return new[] { i, j };
                }
            }
            return new int[0];
        }

        public static int[] GetTwoSumUsingHashMap(int[] numbers, int target)
        {
            Dictionary<int,int> prevMap = new Dictionary<int,int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int complement = target - numbers[i];
                if (prevMap.ContainsKey(complement))
                {
                    return new int[] { prevMap[complement], i };
                }

                if (!prevMap.ContainsKey(numbers[i]))
                {
                    prevMap.Add(numbers[i],i);
                }
            }

            return new int[0];
        }
    }
}
