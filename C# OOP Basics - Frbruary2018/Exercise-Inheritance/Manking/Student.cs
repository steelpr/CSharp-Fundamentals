using System;
using System.Collections.Generic;
using System.Text;

public class Student : Human
{
    private string facultyNumber;

    public Student(string firstName, string lastName, string fNumber) : base(firstName, lastName)
    {
        FacultyNumber = fNumber;
    }

    public string FacultyNumber
    {
        get { return facultyNumber; }
        set
        {
            Validator.ValidFacultyNumber(value);
            facultyNumber = value;
        }
    }

    public override string ToString()
    {
        StringBuilder studentBuilder = new StringBuilder();
        studentBuilder.AppendLine(base.ToString())
            .AppendLine($"Faculty number: {FacultyNumber}");
        string result = studentBuilder.ToString().TrimEnd();
        return result;
    }
}
