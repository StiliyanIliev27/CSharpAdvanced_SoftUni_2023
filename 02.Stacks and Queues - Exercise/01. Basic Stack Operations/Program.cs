namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            int elementsToRemove = numbers[1];
            int elementToLookFor = numbers[2];

            for (int i = 0; i < elementsToRemove; i++)
            {
                stack.Pop();
            }

            if (!stack.Any())
            {
                Console.WriteLine(0);
                return;
            }

            if (stack.Contains(elementToLookFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}