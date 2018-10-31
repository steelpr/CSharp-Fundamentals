using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public class Validator
{
    const string PATTERN = @"(^[A-Za-z\d]{5,10}$)";

    public static void ValidHumanFirstName(string name)
    {
        if (!(char.IsUpper(name[0])))
        {
            throw new ArgumentException($"Expected upper case letter! Argument: firstName");
        }
        else if (name.Length <= 3)
        {
            throw new ArgumentException($"Expected length at least 4 symbols! Argument: firstName");
        }
    }

    public static void ValidHumanLastName(string name)
    {
        if (!(char.IsUpper(name[0])))
        {
            throw new ArgumentException($"Expected upper case letter! Argument: lastName");
        }
        else if (name.Length <= 2)
        {
            throw new ArgumentException($"Expected length at least 3 symbols! Argument: lastName ");
        }
    }

    public static void ValidFacultyNumber(string number)
    {
        if (!Regex.IsMatch(number, PATTERN))
        {
            throw new ArgumentException("Invalid faculty number!");
        }
    }

    public static void WeekSalary(decimal salary)
    {
        if (salary <= 10)
        {
            throw new ArgumentException($"Expected value mismatch! Argument: weekSalary");
        }
    }

    public static void WorkHourDay(double hour)
    {
        if (hour < 1 || hour > 12)
        {
            throw new ArgumentException($"Expected value mismatch! Argument: workHoursPerDay");
        }
    }
}

