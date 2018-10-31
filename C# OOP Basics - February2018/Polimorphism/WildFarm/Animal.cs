using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WildFarm
{
    abstract class Animal
    {
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = 0;
        }

        public virtual double IncreaseWeight => 1;
        public virtual Type[] PreferredFood => new Type[] { typeof(Fruit), typeof(Meat), typeof(Seeds), typeof(Vegetable) };
  
        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }

        public abstract string Sound();

        public void EatFood(Food food)
        {
            Type typeOfFood = food.GetType();

            if (!this.PreferredFood.Contains(typeOfFood))
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {typeOfFood.Name}!");
            }
            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * this.IncreaseWeight;
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{this.Name}, " + "{0}" + $", {this.FoodEaten}]";
        }
    }
}
