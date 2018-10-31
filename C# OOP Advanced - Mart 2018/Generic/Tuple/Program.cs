using System;

class Program
{
    static void Main(string[] args)
    {
        string[] fullName = Console.ReadLine().Split();
        string names = fullName[0] + " " + fullName[1];
        string neighborhood = fullName[2];

        var person = new Tuple<string, string>(names, neighborhood);
        person.Add(person);
        Console.WriteLine(person);

        string[] literBeer = Console.ReadLine().Split();
        string name = literBeer[0];
        int liter = int.Parse(literBeer[1]);

        var beer = new Tuple<string, int>(name, liter);
        beer.Add(beer);
        Console.WriteLine(beer);


        string[] digit = Console.ReadLine().Split();
        int integerNum = int.Parse(digit[0]);
        double doubleNum = double.Parse(digit[1]);

        var integerAndDouble = new Tuple<int, double>(integerNum, doubleNum);
        integerAndDouble.Add(integerAndDouble);
        Console.WriteLine(integerAndDouble);
    }
}