using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Tiger : Feline
    {
        public Tiger(string name, double weight, string livinRegion, string breed)
            : base(name, weight, livinRegion, breed)
        {
        }

        public override Type[] PreferredFood => new Type[] { typeof(Meat) };

        public override double IncreaseWeight => base.IncreaseWeight;

        public override string Sound()
        {
            return "ROAR!!!";
        }

        public override string ToString()
        {
            string baseStr = base.ToString();
            return string.Format(baseStr, this.Breed);
        }
    }
}
