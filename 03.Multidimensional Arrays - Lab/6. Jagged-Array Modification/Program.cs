namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                jagged[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] commandInfo = command.Split();
                string type = commandInfo[0];
                int row = int.Parse(commandInfo[1]);
                int col = int.Parse(commandInfo[2]);
                int value = int.Parse(commandInfo[3]);

                bool isValid = true;
                if (row < 0 || jagged.Length <= row)
                {
                    isValid = false;
                }
                else
                {
                    if (jagged[row].Length <= col || col < 0)
                    {
                        isValid = false;
                    }
                }

                if (isValid)
                {
                    if (type == "Add")
                    {
                        jagged[row][col] += value;
                    }
                    else if (type == "Subtract")
                    {
                        jagged[row][col] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }

                command = Console.ReadLine();
            }
            for (int row = 0; row < jagged.Length; row++)
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