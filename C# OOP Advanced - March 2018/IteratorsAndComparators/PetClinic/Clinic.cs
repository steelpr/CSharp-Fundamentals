using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetClinic
{
    public class Clinic
    {
        private Pet[] pets;

        private int room;

        public Clinic(string name, int room)
        {
            this.Name = name;
            this.Room = room;
            this.pets = new Pet[room];
        }

        public string Name { get; set; }

        public int Room
        {
            get { return room; }
            set
            {
                if (value % 2 == 0)
                {
                    throw new InvalidOperationException("Invalid Operation!");
                }
                room = value;
            }
        }

        public int Center => this.Room / 2;

        public bool HasEmptyRooms => pets.Any(p => p == null);

        public bool Add(Pet pet)
        {
            int currenrRoom = Center;

            for (int i = 0; i < pets.Length; i++)
            {
                if (room == 0)
                {
                    if (pets[currenrRoom] == null)
                    {
                        pets[currenrRoom] = pet;
                        return true;
                    }
                }
                if (i % 2 != 0)
                {
                    currenrRoom -= 1;
                }
                else
                {
                    currenrRoom += 1;
                }

                if (pets[currenrRoom] == null)
                {
                    pets[currenrRoom] = pet;
                    return true;
                }
            }
            return false;
        }

        public bool Release()
        {
            for (int i = 0; i < pets.Length; i++)
            {
                int index = (Center + i) % pets.Length;

                if (pets[index] != null)
                {
                    pets[index] = null;
                    return true;
                }
            }

            return false;
        }

        public string Print(int room)
        {
            return pets[room - 1]?.ToString() ?? "Room empty";
        }

        public string PrintAll()
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 1; i <= pets.Length; i++)
            {
                stringBuilder.AppendLine(Print(i));
            }

            string result = stringBuilder.ToString().Trim();
            return result;
        }
    }
}
