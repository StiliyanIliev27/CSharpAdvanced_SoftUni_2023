using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            List<Tire[]> tiresList = new List<Tire[]>();
            
            string command = Console.ReadLine();
            while(command != "No more tires")
            {
                string[] commandInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);                
                
                int tire1year = int.Parse(commandInfo[0]);
                double tire1pressure = double.Parse(commandInfo[1]);
                int tire2year = int.Parse(commandInfo[2]);
                double tire2pressure = double.Parse(commandInfo[3]);
                int tire3year = int.Parse(commandInfo[4]);
                double tire3pressure = double.Parse(commandInfo[5]);
                int tire4year = int.Parse(commandInfo[6]);
                double tire4pressure = double.Parse(commandInfo[7]);

                Tire tireOne = new Tire(tire1year, tire1pressure);
                Tire tireTwo = new Tire(tire2year, tire2pressure);
                Tire tireThree = new Tire(tire3year, tire3pressure);
                Tire tireFour = new Tire(tire4year, tire4pressure);

                Tire[] carTires = new Tire[4]
                {
                    tireOne,
                    tireTwo,
                    tireThree,
                    tireFour
                };

                tiresList.Add(carTires);

                command = Console.ReadLine();
            }

            List<Engine> engineList = new List<Engine>();

            string secondCommand = Console.ReadLine();
            while(secondCommand != "Engines done")
            {
                string[] commandInfo = secondCommand.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int horsePower = int.Parse(commandInfo[0]);
                double cubicCapacity = double.Parse(commandInfo[1]);

                Engine engine = new Engine(horsePower, cubicCapacity);
                engineList.Add(engine);

                secondCommand = Console.ReadLine();
            }

            List<Car> carsList = new List<Car>(); 

            string thirdCommand = Console.ReadLine();
            while(thirdCommand != "Show special")
            {
                string[] commandInfo = thirdCommand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                
                string make = commandInfo[0];
                string model = commandInfo[1];
                int year = int.Parse(commandInfo[2]);
                double fuelQuantity = double.Parse(commandInfo[3]);
                double fuelConsumption = double.Parse(commandInfo[4]);
                int engineIndex = int.Parse(commandInfo[5]);
                int tireIndex = int.Parse(commandInfo[6]);

                Engine currentEngine = engineList[engineIndex];
                Tire[] currentTires = tiresList[tireIndex];
                
                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, currentEngine, currentTires);
                carsList.Add(car);

                thirdCommand = Console.ReadLine();
            }

            List<Car> filtredCars = carsList.Where(c => c.Year >= 2017)
                .Where(c => c.Engine.HorsePower > 330)
                .Where(c => c.Tires.Sum(x => x.Pressure) >= 9 && c.Tires.Sum(x => x.Pressure) <= 10)
                .ToList();

            foreach (var car in filtredCars)
            {
                car.Drive(20);
                Console.WriteLine(car.WhoAmI());
            }          
        }
    }
}
