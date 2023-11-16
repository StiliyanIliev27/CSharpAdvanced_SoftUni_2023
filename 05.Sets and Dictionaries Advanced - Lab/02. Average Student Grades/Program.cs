namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //I get 50 points here from 100 max. If you can find the problem send me a message. Thanks! :)
            
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> dict = new();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new List<decimal>());
                }
                dict[name].Add(grade);                            
            }
            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {string.Join(" ", kvp.Value)} (avg: {kvp.Value.Average():f2})");
            }
        }
    }
}
