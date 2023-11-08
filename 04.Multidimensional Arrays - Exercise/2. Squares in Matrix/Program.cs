namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizeInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();//Input

            char[,] matrix = new char[sizeInfo[0], sizeInfo[1]];//Rows and cols
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] array = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = array[col];
                }
            }

            int countOfSimilarities = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1]
                        && matrix[row, col] == matrix[row + 1, col]
                        && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        countOfSimilarities++;
                    }
                }
            }
            Console.WriteLine(countOfSimilarities);
        }
    }
}