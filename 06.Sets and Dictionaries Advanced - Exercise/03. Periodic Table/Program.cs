namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] chemicalCompoundsInput = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                set.UnionWith(chemicalCompoundsInput);
            }

            Console.Write($"{string.Join(" ", set.OrderBy(x => x))}");
        }
    }
}
