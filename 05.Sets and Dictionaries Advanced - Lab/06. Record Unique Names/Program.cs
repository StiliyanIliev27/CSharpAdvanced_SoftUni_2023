namespace _06._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> hashSet = new();

            for (int i = 0; i < n; i++)
            {
                hashSet.Add(Console.ReadLine());
            }

            foreach (var name in hashSet)
            {
                Console.WriteLine(name);
            }
        }
    }
}
