using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override Type[] PreferredFood => base.PreferredFood;

        public override double IncreaseWeight => 0.35;

        public override string Sound()
        {
            return "Cluck";
        }
    }
}
