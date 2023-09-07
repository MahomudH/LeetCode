namespace LeetCode.Easy
{
    public class ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            int i = 0;
            int j = s.Length - 1;
            s = s.ToLower();
            while (i < j)
            {
                if (s[i] != s[j])
                {
                    if (IsAlphanumaricChar(s[i]) && IsAlphanumaricChar(s[j]))
                        return false;

                    if (!IsAlphanumaricChar(s[j]))
                        j--;

                    if (!IsAlphanumaricChar(s[i]))
                        i++;
                }
                else
                {
                    j--;
                    i++;
                }
            }

            return true;
        }

        private static bool IsAlphanumaricChar(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9');
        }
    }
}
