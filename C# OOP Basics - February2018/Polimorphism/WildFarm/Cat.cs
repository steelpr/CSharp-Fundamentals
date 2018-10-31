using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Cat : Feline
    {
        public Cat(string name, double weight, string livinRegion, string breed)
            : base(name, weight, livinRegion, breed)
        {
        }

        public override Type[] PreferredFood => new Type[] { typeof(Vegetable), typeof(Meat)};

        public override double IncreaseWeight => 0.30;

        public override string Sound()
        {
            return "Meow";
        }

        public override string ToString()
        {
            string baseStr = base.ToString();
            return string.Format(baseStr, this.Breed);
        }
    }
}
