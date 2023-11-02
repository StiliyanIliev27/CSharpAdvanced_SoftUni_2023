namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalCarsPassed = 0;
            string command = Console.ReadLine();

            Queue<string> cars = new Queue<string>();

            while (command != "end")
            {
                if (command != "green")// car
                {
                    cars.Enqueue(command);
                }
                else
                {
                    for (int i = 0; i < n && cars.Count > 0; i++)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        totalCarsPassed++;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{totalCarsPassed} cars passed the crossroads.");
        }
    }
}