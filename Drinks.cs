using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shukla_Project4
{
    public class Drinks:DishBase
    {
        string Name;
        int Price;
        string Description;
        DishBase Fruits;

        public Drinks(string name, int price, string description, DishBase fruits) : this(name)
        {
            Price = price;
            Description = description;
            Fruits = fruits;
        }

        public Drinks(int price, string description)
        {
            Price = price;
            Description = description;
        }

        public Drinks(string name)
        {
            Name = name;
        }
    }
}
