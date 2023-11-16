namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

                string colour = input[0];

                for (int j = 1; j < input.Length; j++)
                {
                    string currentCloth = input[j];

                    if (!wardrobe.ContainsKey(colour))
                    {
                        wardrobe.Add(colour, new Dictionary<string, int>());
                    }

                    if (!wardrobe[colour].ContainsKey(currentCloth))
                    {
                        wardrobe[colour].Add(currentCloth, 0);
                    }

                    wardrobe[colour][currentCloth]++;
                }
            }

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string clothColourToFind = command[0];
            string clothToFind = command[1];

            foreach (var (colour, currentCloth) in wardrobe)
            {
                Console.WriteLine($"{colour} clothes:");

                foreach (var (cloth, count) in currentCloth)
                {
                    if (cloth == clothToFind && colour == clothColourToFind)
                    {
                        Console.WriteLine($"* {cloth} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth} - {count}");
                    }
                }
            }
        }
    }
}
