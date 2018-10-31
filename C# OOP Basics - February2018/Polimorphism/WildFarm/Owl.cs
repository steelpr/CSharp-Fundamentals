using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override Type[] PreferredFood => new Type[] { typeof(Meat)};

        public override double IncreaseWeight => 0.25;

        public override string Sound()
        {
            return "Hoot Hoot";
        }
    }
}
