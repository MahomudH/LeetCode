namespace LeetCode.Easy
{

    public class MyStack
    {
        private Queue<int> s;
        private int top;
        public MyStack()
        {
            s = new Queue<int>();
        }

        public void Push(int x)
        {
            top = x;
            s.Enqueue(x);
        }

        public int Pop()
        {
            int count = s.Count;
            if (count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            for (int i = 0; i < count - 1; i++)
            {
                this.Push(s.Dequeue());
            }

            return s.Dequeue();

        }

        public int Top()
        {
            if (s.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return top;
        }

        public bool Empty()
        {
            return s.Count == 0;
        }
        public void Print()
        {
            foreach (int x in s)
            {
                Console.Write(x + " ");
            }
        }

    }
