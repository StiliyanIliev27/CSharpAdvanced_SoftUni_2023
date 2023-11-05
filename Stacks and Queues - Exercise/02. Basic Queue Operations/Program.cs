namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            int elementsToRemove = numbers[1];
            int elementToLookFor = numbers[2];

            for (int i = 0; i < elementsToRemove; i++)
            {
                queue.Dequeue();
            }

            if (!queue.Any())
            {
                Console.WriteLine(0);
                return;
            }

            if (queue.Contains(elementToLookFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}