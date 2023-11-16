namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> dictOfNumbers = new();

            for (int i = 0; i < numbers.Length; i++)
            {
                double currentNumber = numbers[i];
                if (!dictOfNumbers.ContainsKey(currentNumber))
                {
                    dictOfNumbers.Add(currentNumber, 0);
                }
                dictOfNumbers[currentNumber] += 1;
            }
            foreach (var kvp in dictOfNumbers)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}