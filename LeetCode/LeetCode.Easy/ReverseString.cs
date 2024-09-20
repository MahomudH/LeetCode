namespace LeetCode.Easy
{
    public class ReverseString
    {
        public static string[] ReverseStringFunc(string[] str)
        {
            string swap = String.Empty;

            for (int i =0, j = str.Length-1; i < j; i++, j--)
            {
                swap = str[i];
                str[i] = str[j];
                str[j] = swap;
            }

            return str;
        }

        public static string[] ReverseStringFuncUsingStack(string[] str)
        {
            Stack<string> stack = new Stack<string>();

            for(var i = 0; i < str.Length; i++)
            {
                stack.Push(str[i]);
            }

            var j = 0;
            while (stack.Count > 0)
            {
                str[j] = stack.Pop();
                j++;
            }
            return str;
        }


    }
}
