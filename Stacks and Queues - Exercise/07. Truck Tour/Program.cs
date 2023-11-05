namespace _07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int petrolPumps = int.Parse(Console.ReadLine());

            Queue<int[]> queue = new Queue<int[]>();

            for (int i = 0; i < petrolPumps; i++)
            {
                int[] info = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                queue.Enqueue(info);
            }

            int startIndex = 0;

            while (true)
            {
                int totalLiters = 0;
                bool isComplete = true;

                foreach (int[] info in queue)
                {
                    int liters = info[0];
                    int distance = info[1];

                    totalLiters += liters;

                    if (totalLiters - distance < 0)
                    {
                        startIndex++;
                        int[] currentPump = queue.Dequeue();
                        queue.Enqueue(currentPump);
                        isComplete = false;
                        break;
                    }

                    totalLiters -= distance;
                }

                if (isComplete)
                {
                    Console.WriteLine(startIndex);
                    break;
                }
            }
        }
    }
}