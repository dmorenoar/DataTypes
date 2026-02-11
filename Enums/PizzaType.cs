using System;
using System.Collections.Generic;
using System.Text;

namespace DataTypes.Enums
{
    //Enum to represent different types of pizza
    //Index starts from 0, so Pepperoni = 0, Veggie = 1, etc.
    public enum PizzaType
    {
        Pepperoni,
        Veggie,
        Pineapple,
        Sausage,
        Mushroom
    }

    //Enum to represent different sizes of pizza and their corresponding prices
    //The price is set as the value of the enum, so Small = 8, Medium = 10, Large = 12
    public enum PizzaSize { 

        Small = 8,
        Medium = 10,
        Large = 12
    }
}
