namespace LeetCode.Easy
{
    public class NumberOfOneBits
    {
        public int HammingWeight(uint n)
        {
            int numberOfOneBits = 0;
            while (n > 0)
            {
                numberOfOneBits += (int)(n % 2);
                n /= 2;
            }
            return numberOfOneBits;
        }
    }
}
