namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customers = new Queue<string>();

            string command = Console.ReadLine();
            int currentCountOfCustomers = 0;

            while (command != "End")
            {
                if (command == "Paid" && customers.Any())
                {
                    Console.WriteLine($"{string.Join(Environment.NewLine, customers)}");
                    for (int i = 0; i < currentCountOfCustomers; i++)
                    {
                        customers.Dequeue();
                    }
                    currentCountOfCustomers = 0;
                }
                else
                {
                    customers.Enqueue(command);
                    currentCountOfCustomers++;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}