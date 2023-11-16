namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipNumbers = new();
            HashSet<string> regularNumbers = new();

            string input = Console.ReadLine();
            while (input != "PARTY")
            {
                if (input[0] >= 48 && input[0] <= 57)
                {
                    vipNumbers.Add(input);
                }
                else
                {
                    regularNumbers.Add(input);
                }

                input = Console.ReadLine();
            }

            string commandParty = Console.ReadLine();
            while (commandParty != "END")
            {
                if (commandParty[0] >= 48 && commandParty[0] <= 57)
                {
                    vipNumbers.Remove(commandParty);
                }
                else
                {
                    regularNumbers.Remove(commandParty);
                }
                commandParty = Console.ReadLine();
            }

            int cnt = regularNumbers.Count + vipNumbers.Count;

            Console.WriteLine(cnt);

            foreach (var vip in vipNumbers)
            {
                Console.WriteLine(vip);
            }
            foreach (var regular in regularNumbers)
            {
                Console.WriteLine(regular);
            }
        }
    }
}
