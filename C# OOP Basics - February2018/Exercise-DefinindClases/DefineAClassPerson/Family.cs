using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class Family
    {

        public List<Person> list;

        public Family()
        {
            this.list = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.list.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.list.OrderByDescending(o => o.Age).FirstOrDefault();
        }
}
