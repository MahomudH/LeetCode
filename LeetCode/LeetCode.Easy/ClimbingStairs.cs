namespace LeetCode.Easy
{
    public class ClimbingStairs
    {
        public static int GetClimbStairs(int n)
        {
            int num1 = 1;
            int num2 = 1;
            int temp;
            for (int i = 0; i < n - 1; i++)
            {
                temp = num1;
                num1 = num1 + num2;
                num2 = temp;
            }

            return num1;
        }
    }
}
