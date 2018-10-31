using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    abstract class Bird : Animal
    {
        public Bird(string name, double weight, double wingSize)
            :base(name, weight)
        {
            this.WingSize = wingSize;
        }

        public double WingSize { get; set; }

        public override string ToString()
        {
            string baseStr = base.ToString();
            string add = $"{this.WingSize}, {this.Weight}";
            return string.Format(baseStr, add);
        }
    }
}
