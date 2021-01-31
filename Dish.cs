using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shukla_Project4
{
    public class Dish
    {
        List<DishBase> DishListfor_Dodo_Pizza = new List<DishBase>();
        List<DishBase> DishListfor_MrTako = new List<DishBase>();
        List<DishBase> DishListfor_NyamNyam = new List<DishBase>();
        public void AddDishtoDodo(DishBase dish)
        {
            if (DishListfor_Dodo_Pizza.Any(x => x.GetDishName() == dish.GetDishName()))
            {
                throw new ArgumentException("Dish with same name already in menu");
            }
            DishListfor_Dodo_Pizza.Add(dish);
        }

        public void AddDishtoTako(DishBase dish)
        {
            if (DishListfor_MrTako.Any(x => x.GetDishName() == dish.GetDishName()))
            {
                throw new ArgumentException("Dish with same name already in menu");
            }
            DishListfor_MrTako.Add(dish);
        }

        public void AddDishtoNyam(DishBase dish)
        {

            if (DishListfor_MrTako.Any(x => x.GetDishName() == dish.GetDishName()))
            {
                throw new ArgumentException("Dish with same name already in menu");
            }
            DishListfor_NyamNyam.Add(dish);

        }


        public List<DishBase> AddingDishtoDodoPizza()
        {


            AddDishtoDodo(new DishBase( "Margarita Pizza", "01", 620, 315,new List<IngredientBase>
            {
                new IngredientBase(IngredientType.Mozzarella_Cheese, 1),
                new IngredientBase(IngredientType.Tomato, 1),
                new IngredientBase(IngredientType.Italian_Herbs, 1),
                new IngredientBase(IngredientType.Tomato_Sauce, 1)

            }));

            AddDishtoDodo(new DishBase("Four Cheese Pizza", "02", 540, 395, new List<IngredientBase>
             {
                new IngredientBase(IngredientType.Mozzarella_Cheese, 1),
                new IngredientBase(IngredientType.Cheddar_Cheese, 1),
                new IngredientBase(IngredientType.Cream_Sauce, 1),
                new IngredientBase(IngredientType.Blue_Cheese, 1)

            }));

            AddDishtoDodo(new DishBase("Pepperoni Pizza", "03", 570, 345, new List<IngredientBase>
             {
                new IngredientBase(IngredientType.Spicy_Pepperoni, 1),
                new IngredientBase(IngredientType.Mozzarella_Cheese, 1),
                new IngredientBase(IngredientType.Tomato_Sauce, 1)

            }));


            AddDishtoDodo(new DishBase("Ham and Mushrooms Pizza", "04", 600, 315, new List<IngredientBase>
             {
                new IngredientBase(IngredientType.Ham, 1),
                new IngredientBase(IngredientType.Mushroom, 1),
                new IngredientBase(IngredientType.Mozzarella_Cheese, 1),
                new IngredientBase(IngredientType.Tomato_Sauce, 1)

            }));

            AddDishtoDodo(new DishBase("Cheeseburger Pizza", "05", 660, 345, new List<IngredientBase>
             {
                new IngredientBase(IngredientType.Meat_Sauce_Bolognese, 1),
                new IngredientBase(IngredientType.Red_Onion, 1),
                new IngredientBase(IngredientType.Mozzarella_Cheese, 1),
                new IngredientBase(IngredientType.Tomato_Sauce, 1)

            }));

            return DishListfor_Dodo_Pizza;

        }

        public List<DishBase> AddingDishtoMr_Tako()
        {
           
            AddDishtoTako(new DishBase("Tori Yaki Chicken", "01", 290, 179, new List<IngredientBase>
            {
                new IngredientBase(IngredientType.Chicken, 1),
                new IngredientBase(IngredientType.Rice, 1),
                new IngredientBase(IngredientType.Onion, 1),
                new IngredientBase(IngredientType.Sesame, 1)

            }));

            AddDishtoTako(new DishBase("Cantonese Pork", "02", 290, 159, new List<IngredientBase>
            {
                new IngredientBase(IngredientType.Minced_Pork, 1),
                new IngredientBase(IngredientType.Rice, 1),
                new IngredientBase(IngredientType.Egg, 1),
                new IngredientBase(IngredientType.Red_Onion, 1),
                new IngredientBase(IngredientType.Cream_Sauce, 1),
                new IngredientBase(IngredientType.Onion, 1),
                new IngredientBase(IngredientType.Sesame, 1)
 
            }));


            AddDishtoTako(new DishBase("Ramen Cheese Soup", "03", 350, 129, new List<IngredientBase>
            {
                new IngredientBase(IngredientType.Chicken, 1),
                new IngredientBase(IngredientType.Wheat_Noodles, 1),
                new IngredientBase(IngredientType.Cheese_Balls, 1),
                new IngredientBase(IngredientType.Sesame, 1),
                new IngredientBase(IngredientType.Chicken, 1),
                new IngredientBase(IngredientType.Tomato, 1),
                new IngredientBase(IngredientType.Cheese_Broth, 1),
                new IngredientBase(IngredientType.Onion, 1)

            }));


            AddDishtoTako(new DishBase("Fried Roll with Salmon", "04", 220, 189, new List<IngredientBase>
            {
                new IngredientBase(IngredientType.Salmon, 1),
                new IngredientBase(IngredientType.Rice, 1),
                new IngredientBase(IngredientType.Onion, 1),
                new IngredientBase(IngredientType.Nori, 1),
                new IngredientBase(IngredientType.Curd_Cheese, 1)

            }));

            AddDishtoTako(new DishBase("Keiseku Salad", "05", 200, 119, new List<IngredientBase>
            {
                new IngredientBase(IngredientType.Peking_Cabbage, 1),
                new IngredientBase(IngredientType.Carrot, 1),
                new IngredientBase(IngredientType.Radish, 1),
                new IngredientBase(IngredientType.Fresh_cucumber, 1),
                new IngredientBase(IngredientType.Chicken, 1),
                new IngredientBase(IngredientType.Mayonnaise, 1),
                new IngredientBase(IngredientType.Onion, 1),
                new IngredientBase(IngredientType.Sesame, 1)

            }));

            return DishListfor_MrTako;

        }

        public List<DishBase> AddingDishtoNyam_Nyam()
        {
        

            AddDishtoNyam(new DishBase("Cheese Shawarma", "01", 310, 209, new List<IngredientBase>
            {
                new IngredientBase(IngredientType.Chicken, 1),
                new IngredientBase(IngredientType.Lavash, 1),
                new IngredientBase(IngredientType.Fresh_cucumber, 1),
                new IngredientBase(IngredientType.Tomato, 1),
                new IngredientBase(IngredientType.Carrot, 1),
                new IngredientBase(IngredientType.Chinese_Cabbage, 1),
                new IngredientBase(IngredientType.Cheddar_Cheese, 1),
                new IngredientBase(IngredientType.Mozzarella_Cheese, 1),
                new IngredientBase(IngredientType.Gouda_Cheese, 1),
                

            }));

            AddDishtoNyam(new DishBase("Siberan Dumplings", "02", 350, 179, new List<IngredientBase>
            {
                new IngredientBase(IngredientType.Dough, 1),
                new IngredientBase(IngredientType.Minced_Pork, 1),
                new IngredientBase(IngredientType.Minced_Beef, 1),

            }));

            AddDishtoNyam(new DishBase("Chicken Kebab", "03", 150, 229, new List<IngredientBase>
            {
                new IngredientBase(IngredientType.Chicken, 1),
                new IngredientBase(IngredientType.Lavash, 1),
                new IngredientBase(IngredientType.Pickled_Onion, 1),
               

            }));

            AddDishtoNyam(new DishBase("Greek Salad", "04", 220, 185, new List<IngredientBase>
            {
                new IngredientBase(IngredientType.Tomato, 1),
                new IngredientBase(IngredientType.Bell_Pepper, 1),
                new IngredientBase(IngredientType.Fresh_cucumber, 1),
                new IngredientBase(IngredientType.Carmel_Onion, 1),
                new IngredientBase(IngredientType.Olives, 1),
                new IngredientBase(IngredientType.Olive_oil, 1),
                new IngredientBase(IngredientType.Feta_Cheese, 1),
                
            }));


            AddDishtoNyam(new DishBase("Quesadilla Vegetarian", "05", 250, 189, new List<IngredientBase>
            {
                new IngredientBase(IngredientType.Lavash, 1),
                new IngredientBase(IngredientType.Bell_Pepper, 1),
                new IngredientBase(IngredientType.Mushroom, 1),
                new IngredientBase(IngredientType.Italian_Herbs, 1),
                new IngredientBase(IngredientType.Hard_Cheese, 1),
             
            }));

            return DishListfor_NyamNyam;

        }
        }  
}

        //public List<DishBase> GetDishFromNyam_Nyam()
        //{
        //    List<DishBase> DishListfor_NyamNyam = new List<DishBase>();

        //    DishListfor_NyamNyam.Add(new DishBase("0001","Cheese Shawarma ", 20, 53200, "Made of flour,Yeast,Vegetable oil,Salt,Water and Sugar", 10));
        //    DishListfor_NyamNyam.Add(new DishBase("0002","Chicken Kebab", 20, 53200, "Made of flour,Yeast,Vegetable oil,Salt,Water and Sugar", 10));
        //    DishListfor_NyamNyam.Add(new DishBase("0003","Greek Salad", 30, 53200, "Freshly prepared tomato ketchup", 10));
        //    DishListfor_NyamNyam.Add(new DishBase("0004","Siberian Dumplings", 40, 53200, "That bite you need for your pizza slice", 10));
        //    DishListfor_NyamNyam.Add(new DishBase("0005","Quesadilla Vegetarian", 10, 53200, "Tastes best with Veggies", 10));
        //    DishListfor_NyamNyam.Add(new DishBase("0006","Grilled Chicken Wings", 25, 53200, "ENgloand's famous Cheese ",10));

        //    return DishListfor_NyamNyam;
        //}


         











    