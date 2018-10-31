using System;
using System.Collections.Generic;

class StartUp
{
    static void Main(string[] args)
    {
        try
        {
            string[] student = Console.ReadLine().Split();

            string firstNameStudent = student[0];
            string lastNameStudent = student[1];
            string facultyNumber = student[2];
            Student studentData = new Student(firstNameStudent, lastNameStudent, facultyNumber);

            string[] worker = Console.ReadLine().Split();

            string firstNamaWorker = worker[0];
            string lastNameWorker = worker[1];
            decimal weekSalary = decimal.Parse(worker[2]);

            int workingHour = int.Parse(worker[3]);

            Worker workerProfile = new Worker(firstNamaWorker, lastNameWorker, weekSalary, workingHour);

            Console.WriteLine(studentData);
            Console.WriteLine();
            Console.WriteLine(workerProfile);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
