﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    abstract class Food
    {
        public Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity { get; set; }
    }
}
