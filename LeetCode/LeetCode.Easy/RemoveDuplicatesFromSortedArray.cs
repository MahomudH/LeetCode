namespace LeetCode.Easy
{
    public class RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicates(int[] arr)
        {
            int x = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[x])
                {
                    arr[++x] = arr[i];
                    if (arr[x] == arr[arr.Length - 1])
                        break;
                }
            }
            return x + 1;
        }

    }
}
