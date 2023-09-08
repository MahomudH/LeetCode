namespace LeetCode.Easy
{
    public class CanPlaceFlowers
    {
        public static bool CanPlaceFlower(int[] flowered, int n)
        {
            int count = 0;
            for (int i = 0, length = flowered.Length; i < length && count < n; i++)
            {
                if (flowered[i] == 0)
                {
                    int prev = i == 0 ? 0 : flowered[i - 1];
                    int next = i == length - 1 ? 0 : flowered[i + 1];

                    if (prev == 0 && next == 0)
                    {
                        flowered[i] = 1;
                        count++;
                    }
                }
            }

            return count == n;
        }
    }
}
