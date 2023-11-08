namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                int[] cols = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jagged[row] = cols;
            }
            for (int row = 0; row < rows - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] *= 2;
                        jagged[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] /= 2;
                    }
                    for (int col = 0; col < jagged[row + 1].Length; col++)
                    {
                        jagged[row + 1][col] /= 2;
                    }
                }
            }
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandInfo = command.Split();
                string commandType = commandInfo[0];
                int row = int.Parse(commandInfo[1]);
                int col = int.Parse(commandInfo[2]);
                int value = int.Parse(commandInfo[3]);

                if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length)
                {
                    if (commandType == "Add")
                    {
                        jagged[row][col] += value;
                    }
                    else if (commandType == "Subtract")
                    {
                        jagged[row][col] -= value;
                    }
                }
                command = Console.ReadLine();
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write($"{jagged[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}