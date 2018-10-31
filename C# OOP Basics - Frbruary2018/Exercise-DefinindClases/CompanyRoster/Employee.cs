using System;
using System.Collections.Generic;
using System.Text;

public class Employee
{
    private string name;
    private decimal salary;
    private string position;
    private string email;
    private int age;

    public Employee (string name, decimal salary, string position, string email = "n/a", int age = 1)
    {
        this.Name = name;
        this.Salary = salary;
        this.Position = position;
        this.Email = email;
        this.Age = age;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public decimal Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public string Position
    {
        get { return position; }
        set { position = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
}
