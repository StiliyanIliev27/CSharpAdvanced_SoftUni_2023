namespace _1._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }
            while (stack.Count > 0)
            {
                char result = stack.Pop();
                Console.Write(result);
            }
            // Console.WriteLine(String.Join("", stack));
        }
    }
}