using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Rectangles> rec = new List<Rectangles>();

        string[] parameter = Console.ReadLine().Split();

        int count = int.Parse(parameter[0]);
        int check = int.Parse(parameter[1]);

 
        for (int i = 0; i < count; i++)
        {
            string[] data = Console.ReadLine().Split();

            string name = data[0];
            int weight = int.Parse(data[1]);
            int heght = int.Parse(data[2]);
            int coordinateC1 = int.Parse(data[3]);
            int coordinateC2 = int.Parse(data[4]);

             Rectangles newRec = new Rectangles(name, weight, heght, coordinateC1, coordinateC2);
            rec.Add(newRec);
        }

        string[] ids = Console.ReadLine().Split();
        string nameFirst = ids[0];
        string nameSecond = ids[1];

        for (int i = 0; i < check; i++)
        {
            foreach (var rec1 in rec.Where(n => n.Id == nameFirst))
            {
                foreach (var rec2 in rec.Where(n => n.Id == nameSecond))
                {
                    Rectangles rectangle = new Rectangles();
                    Rectangle check1 = new Rectangle(rec1.CoordinatesOne, rec1.CooredinatesTwo, rec1.Width, rec1.Height);
                    Rectangle check2 = new Rectangle(rec2.CoordinatesOne, rec2.CooredinatesTwo, rec2.Width, rec2.Height);

                    rectangle.Intersect(check1, check2);
                }
            }
        }
    }
}
