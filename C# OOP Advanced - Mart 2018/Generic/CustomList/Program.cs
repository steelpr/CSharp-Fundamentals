using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string custom = string.Empty;

        var customManager = new CustomManager<string>();

        while ((custom = Console.ReadLine()) != "END")
        {
            string[] data = custom.Split(" ");

            string write = data[0];

            string value;
            switch (write)
            {
                case "Add":
                    value = data[1];
                    customManager.Add(value);
                    break;
                case "Max":
                    Console.WriteLine(customManager.Max());
                    break;
                case "Min":
                    Console.WriteLine(customManager.Min());
                    break;
                case "Greater":
                    value = data[1];
                    Console.WriteLine(customManager.CountGreatThan(value));
                    break;
                case "Swap":
                    int indexOne = int.Parse(data[1]);
                    int indexTwo = int.Parse(data[2]);
                    customManager.Swap(indexOne, indexTwo);
                    break;
                case "Sort":
                    customManager.Sort();
                    break;
                case "Contains":
                    value = data[1];
                    Console.WriteLine(customManager.Contains(value));
                    break;
                case "Print":
                    Console.WriteLine(customManager);
                    break;
                case "Remove":
                    int index = int.Parse(data[1]);
                    customManager.Remove(index);
                    break;
                default:
                    break;
            }
        }
    }
}