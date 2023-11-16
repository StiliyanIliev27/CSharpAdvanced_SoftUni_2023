namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> countSymbols = new();

            string input = Console.ReadLine();

            foreach (char ch in input)
            {
                if (!countSymbols.ContainsKey(ch))
                {
                    countSymbols.Add(ch, 0);
                }
                countSymbols[ch]++;
            }

            foreach (var kvp in countSymbols)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
