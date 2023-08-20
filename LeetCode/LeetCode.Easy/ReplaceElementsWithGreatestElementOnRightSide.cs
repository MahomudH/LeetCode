namespace LeetCode.Easy
{
    public class ReplaceElementsWithGreatestElementOnRightSide
    {
        public int[] ReplaceElements(int[] arr)
        {
            if (arr == null || arr.Length == 0) return arr;

            int maxFromRight = -1; // Initialize with -1 as mentioned in problem statement

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int current = arr[i];   // Save current value
                arr[i] = maxFromRight;  // Replace current with max from right
                if (current > maxFromRight) maxFromRight = current; // Update max if necessary
            }

            return arr;
        }

    }
}
