namespace LeetCode.Easy
{
    public static class BinarySearch
    {
        public static int FindIndexOfTarget(int[] arr, int target)
        {
            int leftP = 0, rightP = arr.Length - 1;
            int med;

            while (leftP < rightP)
            {
                med =( leftP + rightP )/ 2;
                if (arr[med] == target)
                {
                    return med;
                }
                else if (arr[med] > target)
                {
                    rightP = med - 1;
                }
                else  
                {
                    leftP = med + 1;
                }
            }
            return -1;
        }
    }
}
