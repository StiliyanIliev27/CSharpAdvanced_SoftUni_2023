namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> dict = new();

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(currentNumber))
                {
                    dict.Add(currentNumber, 0);
                }
                dict[currentNumber]++;
            }

            Console.WriteLine(dict.Single(x => x.Value % 2 == 0).Key);
        }
    }
}
