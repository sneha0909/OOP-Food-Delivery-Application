using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shukla_Project4
{
    public class Stock
    {
        public List<IngredientBase> IngredientsList { get; set; } = new List<IngredientBase>();

        public void DecreaseFromStock(IngredientType type, int quantity)
        {
            var ing = IngredientsList.FirstOrDefault(x => x.Type == type);
            if (ing == null)
            {
                throw new KeyNotFoundException("Thera are no such ingredient in stock");
            }

            ing.Decrease(quantity);
        }
    }
}
