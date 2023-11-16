namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> nestedDictionary = new();
            string command = Console.ReadLine();

            while (command != "Revision")
            {
                string[] commandInfo = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = commandInfo[0];
                string product = commandInfo[1];
                double price = double.Parse(commandInfo[2]);

                if (!nestedDictionary.ContainsKey(shop))
                {
                    nestedDictionary.Add(shop, new Dictionary<string, double>());
                }

                if (!nestedDictionary[shop].ContainsKey(product))
                {
                    nestedDictionary[shop].Add(product, price);
                }

                nestedDictionary[shop][product] = price;

                command = Console.ReadLine();
            }

            foreach (var (shop, products) in nestedDictionary.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{shop}->");

                foreach (var (product, price) in products)
                {
                    Console.WriteLine($"Product: {product}, Price: {price}");
                }
            }
        }
    }
}
