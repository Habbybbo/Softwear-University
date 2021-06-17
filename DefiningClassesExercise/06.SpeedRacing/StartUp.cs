using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = carData[0];
                double fuelAmount = double.Parse(carData[1]);
                double fuelConsumptionForOneKm = double.Parse(carData[2]);

                Car currCar = new Car
                {
                    Model = model,
                    FuelAmount = fuelAmount,
                    FuelConsumptionPerKilometer = fuelConsumptionForOneKm
                };

                cars.Add(currCar);
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandData = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = commandData[1];
                double distanceTraveled = double.Parse(commandData[2]);

                Car car = cars.FirstOrDefault(c => c.Model == model);

                bool isDrive = car.Drive(distanceTraveled);

                if (isDrive == false)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}
