namespace LeetCode.Easy
{
    public class UglyNumber
    {
        public static bool IsUglyNumber(int number)
        {
            if(number <= 0) return false;

            foreach (var n in new int[] {2,3,5})
            {
                while (number % n == 0)
                {
                    number /= n;
                }
            } 
          
            return number == 1;
        }
    }
}
