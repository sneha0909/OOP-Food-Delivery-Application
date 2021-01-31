using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shukla_Project4
{
    public class IngredientBase
    {
       
        public int Quantity;//Quantity is in Kgs

        public IngredientType Type { get; private set; }

        public IngredientBase()
        {


        }

        public IngredientBase(IngredientType type)
        {
            Type = type;
        }

        public IngredientBase(IngredientType type, int quantity)
        {
         
            this.Quantity = quantity;
            Type = type;

        }

        public void Decrease(int q)
        {
            var current = Quantity;
            Quantity -= q;
            if (Quantity < 0)
            {
                Quantity = current;
                throw new ArgumentException("Cannot decrease more that you have");
            }
        }



        public int GetQuantity()
        {
            return Quantity;


        }

        
    }
        public enum IngredientType
        {
             Mozzarella_Cheese,
             Tomato,
             Italian_Herbs,
             Tomato_Sauce,
             Cheddar_Cheese,
             Cream_Sauce,
             Chicken,
             Pineapple,
             Ham,
             Mushroom,
             Spicy_Pepperoni,
             Meat_Sauce_Bolognese,
             Red_Onion,
             Peking_Cabbage,
             Carrot,
             Radish,
             Mayonnaise,
             Onion,
             Sesame,
             Chinese_Cabbage,
             Egg,
             Soy_Sauce,
             Rice,
             Nori,
             Salmon,
             Curd_Cheese,
             Tortilla,
             Wheat_Noodles,
             Tempura_Flakes,
             Cheese_Balls,
             Cheese_Broth,
             Dough,
             Carmel_Onion,
             Lavash,
             Sour_Cream,
             Cheese_Tortilla,
             Hard_Cheese,
             Bell_Pepper,
             Minced_Beef,
             Minced_Pork,
             Fresh_cucumber,
             Feta_Cheese,
             Olives,
             Olive_oil,
             Pickled_Onion,
             Gouda_Cheese,
             Blue_Cheese,

        }

}
