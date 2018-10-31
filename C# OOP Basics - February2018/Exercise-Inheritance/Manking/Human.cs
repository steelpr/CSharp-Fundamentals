using System;
using System.Collections.Generic;
using System.Text;

public class Human
{
    private string firstName;
    private string lastName;

    public Human(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public virtual string FirstName
    {
        get { return firstName; }
        set
        {
            Validator.ValidHumanFirstName(value);
            firstName = value;
        }
    }

    public virtual string LastName
    {
        get { return lastName; }
        set
        {
            Validator.ValidHumanLastName(value);
            lastName = value;
        }
    }

    public override string ToString()
    {
        StringBuilder humenBuilder = new StringBuilder();
        humenBuilder.AppendLine($"First Name: {FirstName}")
        .AppendLine($"Last Name: {LastName}");
        string result = humenBuilder.ToString().TrimEnd();
        return result;
    }
}
