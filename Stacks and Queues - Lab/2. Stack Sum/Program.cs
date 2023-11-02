namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> stack = new Stack<int>(numbers);

            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {
                string[] tokens = command.Split();
                string commandType = tokens[0];

                if (commandType == "add")
                {
                    int firstNumber = int.Parse(tokens[1]);
                    int secondNumber = int.Parse(tokens[2]);
                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
                else if (commandType == "remove")
                {
                    int numbersToRemove = int.Parse(tokens[1]);

                    if (numbersToRemove > stack.Count)
                    {
                        command = Console.ReadLine().ToLower();
                        continue;
                    }
                    for (int i = 0; i < numbersToRemove; i++)
                    {
                        stack.Pop();
                    }
                }
                command = Console.ReadLine().ToLower();
            }
            int sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}