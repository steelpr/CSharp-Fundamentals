using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem2
{
    public class Database
    {
        private int[] storeIntegers;
        private int index;

        public Database()
        {
            this.StoreIntegers = new int[16];
            this.index = 0;
        }

        public Database(params int[] numbers)
            : this()
        {
            this.InitializeValues(numbers);
        }

        public int[] StoreIntegers
        {
            get { return storeIntegers; }
            set { storeIntegers = value; }
        }

        public void InitializeValues(int[] value)
        {
            try
            {
                Array.Copy(value, this.StoreIntegers, value.Length);
                this.index += value.Length;
            }
            catch(ArgumentException ex)
            {
                throw new InvalidOperationException("The size of the Database must be with 16 length", ex);

            }

        }

        public void Add(int number)
        {
            if (this.index >= 16)
            {
                throw new InvalidOperationException("The size of the Database must be with 16 length");
            }
            this.storeIntegers[index] = number;
            index++;
        }

        public void Remove()
        {
            if (this.index == 0)
            {
                throw new InvalidOperationException("Database is empty!");

            }
            this.storeIntegers[this.index] = 0;
            this.index--;
        }

        public int[] Fetch()
        {
            int[] newDatabase = new int[index];
            Array.Copy(storeIntegers, newDatabase, index);

            return newDatabase;
        }
    }
}
