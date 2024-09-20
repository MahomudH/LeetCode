namespace LeetCode.Medium
{
    public class EvaluateReversePolishNotation
    {
        public static int EvalRPN(string[] tokens)
        {
            var stack = new Stack<int>();
            foreach (var c in tokens)
            {
                if (c == "+")
                {
                    stack.Push(stack.Pop() + stack.Pop());
                }
                else if (c == "-")
                {
                    int a = stack.Pop();
                    int b = stack.Pop();
                    stack.Push(b - a);
                }
                else if (c == "*")
                {
                    stack.Push(stack.Pop() * stack.Pop());
                }
                else if (c == "/")
                {
                    int a = stack.Pop();
                    int b = stack.Pop();
                    stack.Push(b / a);
                }
                else
                {
                    stack.Push(int.Parse(c));
                }
            }
            return stack.Pop();
        }
    }
}

