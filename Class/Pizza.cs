using DataTypes.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTypes.Models
{
    public class Pizza
    {
        public PizzaType Type { get; set; }
        public PizzaSize Size { get; set; }

        public int Price { get; set; }

        public Pizza(PizzaType pizzaType, PizzaSize pizzaSize)
        {
            Type = pizzaType;
            Size = pizzaSize;
            Price = (int) pizzaSize; //Get the price based on the size of the pizza using the enum value
        }
    }
}
