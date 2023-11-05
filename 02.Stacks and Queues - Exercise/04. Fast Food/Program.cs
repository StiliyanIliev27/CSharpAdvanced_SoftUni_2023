namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //80 out of 100 points in Judge. You can try to solve the problem and find my error

            int quantityOfFood = int.Parse(Console.ReadLine());

            Queue<int> orders = new(
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Console.WriteLine(orders.Max());

            while (orders.Any())
            {
                quantityOfFood -= orders.Peek();

                if (quantityOfFood < 0)
                {
                    break;
                }

                orders.Dequeue();
            }
            if (orders.Any())
            {
                Console.WriteLine($"Orders left: {string.Join(", ", orders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}