namespace LeetCode.Easy
{
    public class ValidParentheses
    {
        public static bool IsValid(string text)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in text)
            {
                switch (c)
                {
                    case '(':
                    case '[':
                    case '{':
                        stack.Push(c);
                        break;
                    case ')':
                        if(stack.Count == 0 || stack.Pop() != '(') return false;
                        break;
                    case ']':
                        if(stack.Count == 0 || stack.Pop() != '[') return false;
                        break;
                    case '}':
                        if(stack.Count == 0 || stack.Pop() != '{') return false;
                        break;
                }
            }
            return true;
        }
    }
}
