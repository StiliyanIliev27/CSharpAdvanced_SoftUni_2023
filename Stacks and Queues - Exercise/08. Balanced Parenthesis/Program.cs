namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            foreach (char parenthese in text)
            {
                switch (parenthese)
                {
                    case '(':
                    case '{':
                    case '[':
                        stack.Push(parenthese);
                        break;
                    case '}':
                        if (stack.Count == 0 || stack.Pop() != '{')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                    case ')':
                        if (stack.Count == 0 || stack.Pop() != '(')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                    case ']':
                        if (stack.Count == 0 || stack.Pop() != '[')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                }
            }
            if (stack.Count > 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}