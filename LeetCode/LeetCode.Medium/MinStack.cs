namespace LeetCode.Medium
{
    public class MinStack
    {
        private Stack<int> stack;
        private Stack<int> minStack;

        public MinStack()
        {
            stack = new Stack<int>();
            minStack = new Stack<int>();
        }

        public void Push(int value)
        {
            stack.Push(value);
            if (minStack.Count == 0 || value <= minStack.Peek())
            {
                minStack.Push(value);
            }
        }

        public void Pop()
        {
            if (stack.Count > 0)
            {
                if (stack.Peek() == minStack.Peek())
                {
                    minStack.Pop();
                }
                stack.Pop();
            }
        }

        public int Top()
        {
            if (stack.Count > 0)
            {
                return stack.Peek();
            }
            throw new InvalidOperationException("Stack is empty");
        }

        public int GetMin()
        {
            if (minStack.Count > 0)
            {
                return minStack.Peek();
            }
            throw new InvalidOperationException("Stack is empty.");
        }
    }
}
