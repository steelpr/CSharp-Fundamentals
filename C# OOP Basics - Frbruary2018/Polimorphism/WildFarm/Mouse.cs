using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livinRegion)
            : base(name, weight, livinRegion)
        {
        }

        public override Type[] PreferredFood => new Type[] { typeof(Vegetable), typeof(Fruit) };

        public override double IncreaseWeight => 0.10;

        public override string Sound()
        {
            return "Squeak";
        }

        public override string ToString()
        {
            string baseStr = base.ToString();
            string add = $"{this.Weight}, {this.LivingRegion}";
            return string.Format(baseStr, add);
        }
    }
}
