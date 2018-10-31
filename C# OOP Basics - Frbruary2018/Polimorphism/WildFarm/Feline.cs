using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    abstract class Feline : Mammal
    {
        public Feline(string name, double weight, string livinRegion, string breed)
            : base(name, weight, livinRegion)
        {
            this.Breed = breed;
        }

        public string Breed { get; set; }

        public override string ToString()
        {
            string baseStr = base.ToString();
            string add = $"{this.Breed}, { this.Weight}, {this.LivingRegion}";
            return string.Format(baseStr, add);
        }
    }
}
