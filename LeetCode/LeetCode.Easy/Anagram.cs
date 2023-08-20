using System.Security.Cryptography;

namespace LeetCode.Easy
{
    public class Anagram
    {
        //this is my solution
        public static bool IsAnagram(string first, string second)
        {
            if (first.Length != second.Length) return false;

            char[] charArray1 = first.ToCharArray();
            Array.Sort(charArray1);
            string sortedFirst = new string(charArray1);

            char[] charArray2 = second.ToCharArray();
            Array.Sort(charArray2);
            string sortedSecond = new string(charArray2);

            return sortedFirst.Equals(sortedSecond);
        }

        //this is LeetCode solution
        public static bool AreAnagrams(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in str1)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            foreach (char c in str2)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]--;
                    if (charCount[c] == 0)
                        charCount.Remove(c);
                }
                else
                    return false;
            }

            return charCount.Count == 0;
        }

    }
}
