using System;
using System.Collections.Generic;

namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> allCar = new List<Car>();
            List<Engine> powerEngine = new List<Engine>();

            Engine power = new Engine();
            Car cart = new Car();

            int countEngine = int.Parse(Console.ReadLine());

            for (int i = 0; i < countEngine; i++)
            {
                string[] engine = Console.ReadLine().Split();
                power = GetEngine(engine);
                powerEngine.Add(power);
            }

            int countCar = int.Parse(Console.ReadLine());

            for (int i = 0; i < countCar; i++)
            {
                string[] car = Console.ReadLine().Split();
                 cart = GetCar(car);
                allCar.Add(cart);
            }


            if (cart.Model.Contains(power.Model))
            {

            }
           
        }

        static Car GetCar(string[] car)
        {
            Car jeep = new Car(car[0], car[1], "n/a");

            if (car.Length == 4)
            {
                jeep.Weight = car[2];
                jeep.Color = car[3];
            }
            else if (car.Length == 3)
            {
                int n = 0;
                bool isWeight = int.TryParse(car[2], out n);
                jeep.Weight = n.ToString();

                if (!isWeight)
                {
                    jeep.Weight = "n/a";
                    jeep.Color = car[2];
                }
            }
            return jeep;

        }

        static Engine GetEngine(string[] engine)
        {
            Engine enginePower = new Engine(engine[0], engine[1], "n/a", "n/a");

            if (engine.Length == 4)
            {
                enginePower.Displacement = engine[2];
                enginePower.Efficiency = engine[3];
            }

            else if (engine.Length == 3)
            {
                int n = 0;
                bool isDisplacement = int.TryParse(engine[2], out n);
                enginePower.Displacement = n.ToString();

                if (!isDisplacement)
                {
                    enginePower.Displacement = "n/a";

                    enginePower.Efficiency = engine[2];
                }
            }
            return enginePower;
        }
    }
}