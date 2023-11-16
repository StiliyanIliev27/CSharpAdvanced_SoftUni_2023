namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> nestedDictContinents = new();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string continent = command[0];
                string country = command[1];
                string city = command[2];

                if (!nestedDictContinents.ContainsKey(continent))
                {
                    nestedDictContinents.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!nestedDictContinents[continent].ContainsKey(country))
                {
                    nestedDictContinents[continent].Add(country, new List<string>());
                }

                nestedDictContinents[continent][country].Add(city);
            }

            foreach (var (continet, countries) in nestedDictContinents)
            {
                Console.WriteLine($"{continet}:");

                foreach (var (country, city) in countries)
                {
                    Console.WriteLine($"  {country} -> {string.Join(", ", city)}");
                }
            }
        }
    }
}
