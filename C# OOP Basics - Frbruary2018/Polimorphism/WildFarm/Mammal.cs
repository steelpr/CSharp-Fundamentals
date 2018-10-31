using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    abstract class Mammal : Animal
    {
        public Mammal(string name, double weight, string livinRegion) 
            : base(name, weight)
        {
            this.LivingRegion = livinRegion;
        }

        public string LivingRegion { get; set; }



        public override string ToString()
        {
            string baseStr = base.ToString();
            string add = $"{this.LivingRegion}";
            return string.Format(baseStr, "{0}", add);
        }
    }
}
