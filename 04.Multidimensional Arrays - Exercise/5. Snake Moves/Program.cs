namespace _5._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizeInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = sizeInfo[0];
            int cols = sizeInfo[1];
            char[,] matrix = new char[rows, cols];

            string text = Console.ReadLine();
            int currentWordIndex = 0;
            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (currentWordIndex == text.Length)
                        {
                            currentWordIndex = 0;
                        }
                        matrix[row, col] = text[currentWordIndex];
                        currentWordIndex++;
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        if (currentWordIndex == text.Length)
                        {
                            currentWordIndex = 0;
                        }
                        matrix[row, col] = text[currentWordIndex];
                        currentWordIndex++;
                    }
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}