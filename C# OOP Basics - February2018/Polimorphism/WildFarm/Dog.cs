using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Dog : Mammal
    {
        public Dog(string name, double weight, string livinRegion) 
            : base(name, weight, livinRegion)
        {
        }

        public override Type[] PreferredFood => new Type[] { typeof(Meat)};

        public override double IncreaseWeight => 0.40;

        public override string Sound()
        {
            return "Woof!";
        }

        public override string ToString()
        {
            string baseStr = base.ToString();
            string add = $"{this.Weight}, {this.LivingRegion}";
            return string.Format(baseStr, add);
        }
    }
}
