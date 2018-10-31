using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem2
{
    public class Database
    {
        private Person[] storePerson;
        private int index;

        public Database()
        {
            this.storePerson = new Person[16];
            this.index = 0;
        }

        public Database(params Person[] numbers)
            : this()
        {
            this.InitializeValues(numbers);
        }

        //public int[] StoreIntegers
        //{
        //    get { return storeIntegers; }
        //    set { storeIntegers = value; }
        //}

        public void InitializeValues(params Person[] value)
        {
            try
            {
                Array.Copy(value, this.storePerson, value.Length);
                this.index += value.Length;
            }
            catch(ArgumentException ex)
            {
                throw new InvalidOperationException("The size of the Database must be with 16 length", ex);

            }

        }

        public void Add(Person person)
        {
            var id = this.storePerson.FirstOrDefault(i => i.Id == person.Id);
            var username = this.storePerson.FirstOrDefault(u => u.Username == person.Username);
            if (id != null || username != null)
            {
                throw new InvalidOperationException("This Person is already exist");
            }
            this.storePerson[index] = person;
            index++;
        }

        public void Remove()
        {
            if (this.index == 0)
            {
                throw new InvalidOperationException("Database is empty!");

            }
            this.storePerson[this.index] = null;
            this.index--;
        }

        public Person FindById(long id)
        {
            if (id < 0)
            {
                throw new ArgumentException("The Id was negative!");
            }

            var findId = this.storePerson.First(i => i.Id == id);
            if (findId == null)
            {
                throw new InvalidOperationException("Nod exist Person with this id!");
            }
            return findId;
        }

        public Person FindByUsername(string username)
        {
            if (username == null)
            {
                throw new ArgumentNullException("The username can't null");
            }

            var finrUsername = this.storePerson.First(n => n.Username == username);
            if(finrUsername == null)
            {
                throw new InvalidOperationException("Not exist Persint with this username");
            }
            return finrUsername;
        }

        //public int[] Fetch()
        //{
        //    int[] newDatabase = new int[index];
        //    Array.Copy(storeIntegers, newDatabase, index);

        //    return newDatabase;
        //}
    }
}
