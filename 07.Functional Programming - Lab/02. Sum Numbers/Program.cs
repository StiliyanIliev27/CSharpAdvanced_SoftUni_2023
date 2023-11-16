namespace _02._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int count = list.Count();
            int sum = list.Sum(x => x);

            Console.WriteLine(count);
            Console.WriteLine(sum);
        }
    }
}
