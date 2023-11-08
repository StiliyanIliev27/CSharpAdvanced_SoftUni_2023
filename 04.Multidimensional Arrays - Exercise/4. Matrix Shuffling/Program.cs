namespace _4._Matrix_Shuffling
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
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] array = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = array[col];
                }
            }
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] commandInfo = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (IsValid(commandInfo, rows, cols))
                {
                    int firstRow = int.Parse(commandInfo[1]);
                    int firstCol = int.Parse(commandInfo[2]);
                    int secondRow = int.Parse(commandInfo[3]);
                    int secondCol = int.Parse(commandInfo[4]);

                    string savedNumber = matrix[firstRow, firstCol];
                    matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                    matrix[secondRow, secondCol] = savedNumber;

                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            Console.Write($"{matrix[row, col]} ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine();
                    continue;
                }
                command = Console.ReadLine();
            }
        }
        static bool IsValid(string[] commandInfo, int rows, int cols)
        {
            if (commandInfo[0] == "swap"
                 && commandInfo.Length == 5
                 && int.Parse(commandInfo[1]) >= 0 && int.Parse(commandInfo[1]) < rows
                 && int.Parse(commandInfo[2]) >= 0 && int.Parse(commandInfo[2]) < cols
                 && int.Parse(commandInfo[3]) >= 0 && int.Parse(commandInfo[3]) < rows
                 && int.Parse(commandInfo[4]) >= 0 && int.Parse(commandInfo[4]) < cols)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}