namespace LeetCode.Easy
{
    public class HappyNumber
    {
        private static int getSumOfSquare(int number)
        {
            int digit = 0;
            int sum = 0;
            while(number > 0)
            {
                digit = number % 10;
                sum += (digit * digit);
                number /= 10;
            }
            return sum;
        }

        public static bool IsHappyNumber(int number)
        {
            HashSet<int> seenNumbers = new HashSet<int>();

            while(number != 1 && !seenNumbers.Contains(number))
            {
                seenNumbers.Add(number);
                number = getSumOfSquare(number);
            }

            return number == 1;
        }

    }
}
