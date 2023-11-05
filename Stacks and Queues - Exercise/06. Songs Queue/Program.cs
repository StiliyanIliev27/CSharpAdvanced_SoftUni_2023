namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(
                 Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries));

            while (songs.Any())
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string commandType = command[0];
                switch (commandType)
                {
                    case "Play":
                        songs.Dequeue();
                        break;
                    case "Add":
                        string song = string.Join(" ", command.Skip(1));
                        if (songs.Contains(song))
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        else
                        {
                            songs.Enqueue(song);
                        }
                        break;
                    case "Show":
                        Console.WriteLine($"{string.Join(", ", songs)}");
                        break;
                }

            }
            Console.WriteLine("No more songs!");
        }
    }
}