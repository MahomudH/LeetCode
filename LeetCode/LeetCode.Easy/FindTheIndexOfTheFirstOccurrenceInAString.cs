namespace LeetCode.Easy
{
    public class FindTheIndexOfTheFirstOccurrenceInAString
    {
        public static int GetIndexOf(string haystack, string needle)
        {
            int lengthOfHaystack = haystack.Length;
            int lengthOfNeedle = needle.Length;

            if (lengthOfNeedle == 0) return 0;
            if (lengthOfNeedle > lengthOfHaystack) return -1;

            for (int i = 0; i < lengthOfHaystack; i++)
            {
                if (lengthOfHaystack - i < lengthOfNeedle)
                    break;

                if (haystack[i] == needle[0])
                {
                    int x = i;
                    for (int j = 0; j < lengthOfNeedle; j++)
                    {
                        if (haystack[x] != needle[j])
                            break;

                        x++;
                        if (j == lengthOfNeedle - 1)
                            return i;
                    }

                }


            }

            return -1;
        }
    }
}
