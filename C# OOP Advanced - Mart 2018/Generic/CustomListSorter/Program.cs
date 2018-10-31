using System;

class Program
{
    static void Main(string[] args)
    {
        string input = string.Empty;

        var sorterManager = new SorterManager<string>();

        while ((input = Console.ReadLine()) != "END")
        {
            string[] data = input.Split(" ");

            switch (data[0])
            {
                case "Add":
                    sorterManager.Add(data[1]);
                    break;
                case "Sort":
                    sorterManager.Sort();
                    break;
                case "Print":
                    Console.WriteLine(sorterManager);
                    break;
                default:
                    break;
            }
        }
    }
}
