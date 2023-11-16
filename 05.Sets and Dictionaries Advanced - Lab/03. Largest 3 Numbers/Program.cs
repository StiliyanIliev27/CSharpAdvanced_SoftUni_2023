namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .OrderByDescending(x => x)
                 .ToList();

            //  int[] numbersByDescending = numbers.OrderByDescending(x => x).ToArray();

            if (numbers.Count < 3)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            else if (numbers.Count >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
