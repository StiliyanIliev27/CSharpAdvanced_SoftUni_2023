namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkingLot = new();

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] commandInfo = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string direction = commandInfo[0].ToLower();
                string carNumber = commandInfo[1];

                if (direction == "in")
                {
                    parkingLot.Add(carNumber);
                }
                else if (direction == "out")
                {
                    if (parkingLot.Contains(carNumber))
                    {
                        parkingLot.Remove(carNumber);
                    }
                }

                command = Console.ReadLine();
            }

            if (parkingLot.Any())
            {
                foreach (var car in parkingLot)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
