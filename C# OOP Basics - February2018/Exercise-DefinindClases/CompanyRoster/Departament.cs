using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Departament
{
    private List<Employee> employee;
    private string name;
    private string departaments;

    public Departament(string name)
    {
        this.employee = new List<Employee>();
        this.Name = name;
    }

    public List<Employee> Employees
    {
        get { return employee; }
        set { employee = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }


    public decimal AverageSalary => this.Employees.Select(m => m.Salary).Average();

    public void AddEmployee(Employee employee)
    {
        this.Employees.Add(employee);
    }
}
