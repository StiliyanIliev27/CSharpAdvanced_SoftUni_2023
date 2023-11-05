namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<string> stack = new Stack<string>(input.Reverse());

            int result = int.Parse(stack.Pop());
            while (stack.Count > 0)
            {
                string sign = stack.Pop();
                int number = int.Parse(stack.Pop());

                if (sign == "+")
                {
                    result += number;
                }
                else if (sign == "-")
                {
                    result -= number;
                }
            }
            Console.WriteLine(result);
        }
    }
}