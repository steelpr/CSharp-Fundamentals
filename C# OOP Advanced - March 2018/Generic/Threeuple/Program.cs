using System;

class Program
{
    static void Main(string[] args)
    {
        string[] citizen = Console.ReadLine().Split();

        string name = citizen[0] + " " + citizen[1];
        string neighborhood = citizen[2];
        string town = citizen[3];

        var personData = new Threeuple<string, string, string>(name, neighborhood, town);
        personData.Add(personData);
        Console.WriteLine(personData);

        string[] intoxicate = Console.ReadLine().Split();
        string drunk = intoxicate[0];
        int liter = int.Parse(intoxicate[1]);
        bool drunkOrNot = false;
        if (intoxicate[2] == "drunk")
        {
            drunkOrNot = true;
        }

        var alcohol = new Threeuple<string, int, bool>(drunk, liter, drunkOrNot);
        alcohol.Add(alcohol);
        Console.WriteLine(alcohol);

        string[] bank = Console.ReadLine().Split();

        string user = bank[0];
        double balance = double.Parse(bank[1]);
        string banks = bank[2];

        var accountBallance = new Threeuple<string, double, string>(user, balance, banks);
        accountBallance.Add(accountBallance);
        Console.WriteLine(accountBallance);
    }
}
