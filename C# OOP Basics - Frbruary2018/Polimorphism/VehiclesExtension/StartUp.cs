using System;
using System.Collections.Generic;

class StartUp
{
    static void Main(string[] args)
    {
        List<Vehicles> collect = new List<Vehicles>();

        string[] car = Console.ReadLine().Split();

        string carModel = car[0];

        double tankCar = double.Parse(car[1]);
        double carLiterKm = double.Parse(car[2]);
        double capacityTankCar = double.Parse(car[3]);

        Vehicles vehiclesCar = new Car(carModel, tankCar, carLiterKm, capacityTankCar);
        collect.Add(vehiclesCar);

        string[] truck = Console.ReadLine().Split();
        string truckModel = truck[0];

        double tankTruck = double.Parse(truck[1]);
        double truckLiterKm = double.Parse(truck[2]);
        double capacityTankTruck = double.Parse(truck[3]);

        Vehicles vehiclesTruck = new Truck(truckModel, tankTruck, truckLiterKm, capacityTankTruck);
        collect.Add(vehiclesTruck);

        string[] bus = Console.ReadLine().Split();
        string busModel = bus[0];

        double tankBus = double.Parse(bus[1]);
        double busLiterKm = double.Parse(bus[2]);
        double busTankCapacity = double.Parse(bus[3]);
        
        Bus vehicleBus = new Bus(busModel, tankBus, busLiterKm, busTankCapacity);
        collect.Add(vehicleBus);

        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            try
            {
                string[] inputVehicles = Console.ReadLine().Split();
                string command = inputVehicles[0];
                string model = inputVehicles[1];

                double distance = double.Parse(inputVehicles[2]);

                if (command == "Drive")
                {
                    switch (model)
                    {
                        case "Car":
                            vehiclesCar.CalculateConsumation(collect, distance);
                            Console.WriteLine(vehiclesCar);
                            break;
                        case "Truck":
                            vehiclesTruck.CalculateConsumation(collect, distance);
                            Console.WriteLine(vehiclesTruck);
                            break;
                        case "Bus":
                            vehicleBus.CalculateConsumationWithAirCondition(collect, distance);
                            Console.WriteLine(vehicleBus);
                            break;
                        default:
                            break;
                    }
                }
                else if (command == "Refuel")
                {
                    switch (model)
                    {
                        case "Car":
                            vehiclesCar.Refuel(collect, distance);
                            break;
                        case "Truck":
                            vehiclesTruck.Refuel(collect, distance);
                            break;
                        case "Bus":
                            vehicleBus.Refuel(collect, distance);
                            break;
                        default:
                            break;
                    }
                }
                else if (command == "DriveEmpty")
                {
                    vehicleBus.CalculateConsumation(collect, distance);
                    Console.WriteLine(vehicleBus);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        double carLiter = vehiclesCar.FuelQuantity;
        double truckLiter = vehiclesTruck.FuelQuantity;
        double busLiter = vehicleBus.FuelQuantity;

        Console.WriteLine($"Car: {carLiter:f2}");
        Console.WriteLine($"Truck: {truckLiter:f2}");
        Console.WriteLine($"Bus: {busLiter:f2}");
    }
}