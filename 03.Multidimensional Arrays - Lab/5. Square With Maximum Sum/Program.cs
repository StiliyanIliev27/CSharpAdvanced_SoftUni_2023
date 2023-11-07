namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = input[0];
            int cols = input[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] array = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = array[col];
                }
            }

            int maxStartRow = 0;
            int maxStartCol = 0;
            int biggestSum = int.MinValue;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    int currentSum = 0;
                    currentSum += matrix[row, col] + matrix[row, col + 1]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (currentSum > biggestSum)
                    {
                        biggestSum = currentSum;
                        maxStartRow = row;
                        maxStartCol = col;
                        currentSum = 0;
                    }
                }
            }
            Console.WriteLine($"{matrix[maxStartRow, maxStartCol]} {matrix[maxStartRow, maxStartCol + 1]}");
            Console.WriteLine($"{matrix[maxStartRow + 1, maxStartCol]} {matrix[maxStartRow + 1, maxStartCol + 1]}");
            Console.WriteLine(biggestSum);
        }
    }
}