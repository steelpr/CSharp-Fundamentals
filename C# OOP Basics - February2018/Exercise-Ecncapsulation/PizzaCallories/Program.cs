using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string pizzaName = Console.ReadLine().Split()[1];
            Pizza pizza = new Pizza(pizzaName);

            string[] doughInput = Console.ReadLine().Split();
            string flourType = doughInput[1];
            string bakingTechnique = doughInput[2];
            double weight = double.Parse(doughInput[3]);

            Dough dough = new Dough(flourType, bakingTechnique, weight);
            pizza.SetDough(dough);

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] toppingData = command.Split();
                string name = toppingData[1];
                double weightTopping = double.Parse(toppingData[2]);

                Topping toppings = new Topping(name, weightTopping);
                pizza.AddTopping(toppings);
            }
            Console.WriteLine(pizza);
        }
        catch (ArgumentException exe)
        {
            Console.WriteLine(exe.Message);
        }
    }
}
