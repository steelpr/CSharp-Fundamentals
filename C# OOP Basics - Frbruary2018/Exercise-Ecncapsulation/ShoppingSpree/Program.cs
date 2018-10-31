using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] personInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            string[] productInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            List<Person> personCollect = new List<Person>();
            List<Product> products = new List<Product>();

            try
            {
                foreach (var personInfo in personInput)
                {
                    string[] input = personInfo.Split('=');
                    string personName = input[0];
                    decimal personMoney = decimal.Parse(input[1]);
                    Person person = new Person(personName, personMoney);
                    personCollect.Add(person);
                }

                foreach (var productInfo in productInput)
                {
                    string[] input = productInfo.Split('=');
                    string productName = input[0];
                    decimal costProduct = decimal.Parse(input[1]);
                    Product product = new Product(productName, costProduct);
                    products.Add(product);
                }
            }
            catch (ArgumentException invalid)
            {
                Console.WriteLine(invalid.Message);
                Environment.Exit(0);
            }


            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] personAndProduct = command.Split();
                string personName = personAndProduct[0];
                string productName = personAndProduct[1];

                Person person = personCollect.First(n => n.Name == personName);
                Product product = products.First(n => n.Name == productName);

                string print = person.TryByProduct(product);
                Console.WriteLine(print);
            }

            foreach (var person in personCollect)
            {
                Console.WriteLine(person);
            }
        }
    }
}
