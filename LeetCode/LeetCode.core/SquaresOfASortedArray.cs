namespace LeetCode.Core
{
    public class SquaresOfASortedArray
    {
        public static int[] GetSquresOfSortedArray(int[] arr)
        {
            int length = arr.Length;
            int leftP = 0, rightP = length - 1;
            int left, right;
            int[] result = new int[length];

            for (int i = length - 1; i >= 0; i--)
            {
                left = arr[leftP] * arr[leftP];
                right = arr[rightP] * arr[rightP];
                if (left > right)
                {
                    result[i] = left;
                    leftP++;
                }
                else
                {
                    result[i] = right;
                    rightP--;
                }
            }

            return result;
        }
    }
}
