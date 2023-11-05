namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new(
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            int capacityOfRack = int.Parse(Console.ReadLine());
            int currentRackSize = capacityOfRack;
            int numberOfRacks = 1;
            while (clothes.Any())
            {
                currentRackSize -= clothes.Peek();

                if (currentRackSize < 0)
                {
                    currentRackSize = capacityOfRack;
                    numberOfRacks++;
                    continue;
                }

                clothes.Pop();
            }
            Console.WriteLine(numberOfRacks);
        }
    }
}