namespace LeetCode.Easy
{
    public class LengthOfLastWord
    {
        public static int GetLength(string s)
        {
            int i = s.Length - 1;
            int length = 0;

            while (i >= 0 && s[i] == ' ')
            {
                i--;
            }

            while (i >= 0 && s[i] != ' ')
            {
                length++;
                i--;
            }
            return length;
        }
    }
}
