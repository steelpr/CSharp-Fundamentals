using System;
using System.Collections.Generic;
using System.Text;

public class Worker : Human
{
    private decimal salaryWeek;
    private double workHourDay;

    public Worker(string firstName, string lastName, decimal salary, double hour) : base(firstName, lastName)
    {
        SalaryWeek = salary;
        WorkHourDay = hour;
    }

    public decimal SalaryWeek
    {
        get { return salaryWeek; }
        set
        {
            Validator.WeekSalary(value);
            salaryWeek = value;
        }
    }
    
    public double WorkHourDay
    {
        get { return workHourDay; }
        set
        {
            Validator.WorkHourDay(value);
            workHourDay = value;
        }
    }

    public override string ToString()
    {
        StringBuilder workerBuilder = new StringBuilder();
        workerBuilder.AppendLine(base.ToString())
        .AppendLine($"Week Salary: {SalaryWeek:f2}")
        .AppendLine($"Hours per day: {WorkHourDay:f2}")
        .AppendLine($"Salary per hour: {MoneyForHour(SalaryWeek, WorkHourDay):f2}");
        string result = workerBuilder.ToString().TrimEnd();
        return result;
    }

    private decimal MoneyForHour(decimal salaryWeek, double workingHour)
    {
        decimal moneyForHour = salaryWeek / (decimal)(workingHour * 5);
        return moneyForHour;
    }
}
