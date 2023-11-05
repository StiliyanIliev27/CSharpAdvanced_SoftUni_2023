namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfOperations = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < countOfOperations; i++)
            {
                string[] commandInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = commandInfo[0];

                switch (command)
                {
                    case "1":
                        int number = int.Parse(commandInfo[1]);
                        numbers.Push(number);
                        break;
                    case "2":
                        numbers.Pop();
                        break;
                    case "3":
                        if (!numbers.Any())
                        {
                            continue;
                        }
                        Console.WriteLine(numbers.Max());
                        break;
                    case "4":
                        if (!numbers.Any())
                        {
                            continue;
                        }
                        Console.WriteLine(numbers.Min());
                        break;
                }
            }
            Console.WriteLine($"{string.Join(", ", numbers)}");
        }
    }
}