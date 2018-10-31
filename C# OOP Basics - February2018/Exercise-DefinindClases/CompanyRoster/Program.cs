using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Departament> departament = new List<Departament>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] employee = Console.ReadLine().Split();
                string departaments = employee[3];

                if (!departament.Any(d => d.Name == departaments))
                {
                    Departament dep = new Departament(departaments);
                    departament.Add(dep);
                }
                var depart = departament.FirstOrDefault(d => d.Name == departaments);
                Employee em = Person(employee);
                depart.AddEmployee(em);
            }

            var highestAverage = departament.OrderByDescending(s => s.AverageSalary).First();

            Console.WriteLine($"Highest Average Salary: {highestAverage.Name}");
            foreach (var item in highestAverage.Employees.OrderByDescending(d => d.Salary))
            {
                Console.WriteLine($"{item.Name} {item.Salary:f2} {item.Email} {item.Age}");
            }
        }

        static Employee Person (string[] person)
        {
            string name = person[0];
            decimal salary = decimal.Parse(person[1]);
            string position = person[2];
            string email = "n/a";
            int age = -1;

            if (person.Length == 6)
            {
                email = person[4];
                age = int.Parse(person[5]);
            }
            else if (person.Length == 5)
            {
                bool isDigit = int.TryParse(person[4], out age);

                if (!isDigit)
                {
                    email = person[4];
                    age = -1;
                }
            }
            Employee employee = new Employee(name, salary, position, email, age);
            return employee;
        }
    }
}
