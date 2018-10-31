using System;
using System.Collections.Generic;
using System.Text;

public class DateModifier
{
  public static double Modifier(string firstDate, string secondDate)
    {
        DateTime dateOne = DateTime.Parse(firstDate);
        DateTime dateTwo = DateTime.Parse(secondDate);
        TimeSpan write = (dateOne - dateTwo);
        return Math.Abs(write.TotalDays);
    }
}
