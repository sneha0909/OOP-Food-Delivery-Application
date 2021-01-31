using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shukla_Project4
{
    public class Menu
    {
        public List<DishBase> Dishes { get; private set; } = new List<DishBase>();

        public void AddDish(DishBase dish)
        {
            if (Dishes.Any(x => x.GetDishName() == dish.GetDishName()))
            {
                throw new ArgumentException("Dish with same name already in menu");
            }
            Dishes.Add(dish);
        }


    }
}
