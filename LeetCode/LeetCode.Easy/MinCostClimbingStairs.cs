namespace LeetCode.Easy
{
    public class MinCostClimbingStairs
    {
        public static int GetMinCostClimbingStairsV1(int[] cost)
        {
           List<int> ints = new List<int>(cost);
            ints.Append(0);

            for (int i = ints.Count-3; i >= 0; i--)
            {
                ints[i] = ints[i] + ints[i+1] < ints[i] + ints[i + 2] ? ints[i] + ints[i + 1] : ints[i] + ints[i + 2];
            }

            return ints[0] < ints[1] ? ints[0] : ints[1];
        }
        // this is better than the V1
        public static int GetMinCostClimbingStairsV2(int[] cost)
        {
            int n = cost.Length;
            if (n == 0) return 0;
            if (n == 1) return cost[0];

            int[] dp = new int[n];
            dp[0] = cost[0];
            dp[1] = cost[1];

            for (int i = 2; i < n; i++)
            {
                dp[i] = cost[i] + Math.Min(dp[i - 1], dp[i - 2]);
            }

            return Math.Min(dp[n - 1], dp[n - 2]);
        }
    }
}
