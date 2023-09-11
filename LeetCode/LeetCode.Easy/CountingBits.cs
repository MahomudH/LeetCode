namespace LeetCode.Easy
{
    public class CountingBits
    {
        public static int[] GetCountBits(int n)
        {
            int[] ans = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                int count = 0;
                int temp = i;
                while (temp > 0)
                {
                    count += temp % 2;
                    temp /=  2;
                }
                ans[i] = count;
            }

            return ans;
        }
    }
}
