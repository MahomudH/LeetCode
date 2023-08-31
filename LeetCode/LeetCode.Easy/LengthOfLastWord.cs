namespace LeetCode.Easy
{
    public class LengthOfLastWord
    {
        public static int GetLength(string s)
        {
            int i = s.Length - 1;
            int length = 0;

            while (s[i] == ' ')
            {
                i--;
            }

            while (length >= 0 && s[i] != ' ')
            {
                length++;
                i--;
            }
            return length;
        }
    }
}
