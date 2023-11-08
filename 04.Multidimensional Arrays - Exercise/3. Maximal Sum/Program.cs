namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizeInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rows = sizeInfo[0];
            int cols = sizeInfo[1];

            if (rows < 3 || cols < 3)
            {
                return;
            }

            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] array = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = array[col];
                }
            }
            int maxSum = int.MinValue;
            int maxStartRowIndex = 0;
            int maxStartColIndex = 0;
            for (int row = 0; row < rows - 2; row++)
            {
                int currentSum = 0;
                for (int col = 0; col < cols - 2; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxStartRowIndex = row;
                        maxStartColIndex = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            for (int row = maxStartRowIndex; row < maxStartRowIndex + 3; row++)
            {
                for (int col = maxStartColIndex; col < maxStartColIndex + 3; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}