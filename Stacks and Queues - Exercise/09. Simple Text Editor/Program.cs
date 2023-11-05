namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<string> changes = new Stack<string>();

            string text = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string commandType = command[0];

                switch (commandType)
                {
                    case "1":
                        changes.Push(text);
                        text += command[1];
                        break;
                    case "2":
                        changes.Push(text);
                        int countToErase = int.Parse(command[1]);
                        text = text.Remove(text.Length - countToErase);
                        break;
                    case "3":
                        int index = int.Parse(command[1]) - 1;
                        Console.WriteLine(text[index]);
                        break;
                    case "4":
                        text = changes.Pop();
                        break;
                }

            }
        }
    }
}