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
            Car car = new Car();

            car.Make = "Audi";
            car.Model = "A8";
            car.Year = 2000;
            car.FuelQuantity = 100;
            car.FuelConsumption = 2;
            car.Drive(10);
            Console.WriteLine(car.WhoAmI());

        }
    }
}
