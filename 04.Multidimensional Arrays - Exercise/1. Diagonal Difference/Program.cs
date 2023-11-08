namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];
            for (int row = 0; row < size; row++)
            {
                int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = array[col];
                }
            }

            int primarySum = 0;
            int primaryCol = 0;
            for (int row = 0; row < size; row++)//Primary sum
            {
                primarySum += matrix[row, primaryCol];
                primaryCol++;
            }

            int secondarySum = 0;
            int secondaryCol = 0;
            for (int row = size - 1; row >= 0; row--)//Secondary sum
            {
                secondarySum += matrix[row, secondaryCol];
                secondaryCol++;
            }
            Console.WriteLine(Math.Abs(primarySum - secondarySum));
        }
    }
}