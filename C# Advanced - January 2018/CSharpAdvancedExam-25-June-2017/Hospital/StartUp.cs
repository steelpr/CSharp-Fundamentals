namespace Hospital
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> listWithPatients = new Dictionary<string, Dictionary<string, string>>();

            Dictionary<string, string> doctorPatients = new Dictionary<string, string>();


            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Output")
            {
                string[] list = input.Split().ToArray();

                string departament = list[0];
                string doctor = list[1] + " " + list[2];
                string patient = list[3];

                if (listWithPatients.ContainsKey(departament))
                {
                    if (doctorPatients.ContainsKey(doctor))
                    {
                        listWithPatients[departament][doctor] += patient;
                    }
                    else
                    {
                        listWithPatients[departament].Add(doctor, patient);
                    }
                }
                else
                {
                    listWithPatients.Add(departament, new Dictionary<string, string>());
                    listWithPatients[departament].Add(doctor, patient);
                }
            }

            string end = string.Empty;
            while ((end = Console.ReadLine()) != "End")
            {
                string[] command = end.Split();

                if (command.Length == 1)
                {
                    foreach (var item in listWithPatients.Where(j => j.Key == command[0]))
                    {
                        foreach (var patient in item.Value)
                        {
                            Console.WriteLine(patient.Value);
                        }
                    }
                }
                else
                {
                    int print = 0;
                    if (int.TryParse(command[1], out print))
                    {
                        int p = 3 * print;
                        int l = 1;
                        foreach (var split in listWithPatients.Where(k => k.Key == command[0]))
                        {
                            foreach (var item in split.Value)
                            {
                                    Console.WriteLine(item.Value);
                            }
                        }
                    }
                    else
                    {
                        if (doctorPatients.ContainsKey(command[0] + " " + command[1]))
                        {
                            foreach (var item in doctorPatients.OrderBy(o => o))
                            {
                                Console.WriteLine(item.Value);
                            }
                        }
                    }
                }
            }
        }
    }
}
