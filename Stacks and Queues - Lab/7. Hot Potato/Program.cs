namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> players = new Queue<string>(
                Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries));

            int n = int.Parse(Console.ReadLine());// 2

            while (players.Count > 1)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    players.Enqueue(players.Dequeue());
                }
                Console.WriteLine($"Removed {players.Dequeue()}");
            }

            Console.WriteLine($"Last is {players.Peek()}");
        }
    }
}