namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            HashSet<int> firstSet = new();
            HashSet<int> secondSet = new();

            for (int i = 0; i < input[0]; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < input[1]; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(string.Join(" ", firstSet.Intersect(secondSet)));
        }
    }
}
