namespace LeetCode.Medium
{
    public class ReverseInterger
    {
        public static int RevirseIntger(int number)
        {
            long result = 0;

            while (number != 0)
            {
                result = (number % 10) + (result * 10);
                number = number / 10;
            }

            if (result > Int32.MaxValue || result < Int32.MinValue)
                return 0;

            return (int) result;
        }
    }
}
