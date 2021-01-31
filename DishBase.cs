using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shukla_Project4
{
    public class DishBase
    {
        private string DishId;
        private string Name;
        private float Weight;
        private float Price;
        public int Calories;


        public List<IngredientBase> IngredientsList { get; private set; }
       

        public DishBase()
        {



        }

        public DishBase(string dishId, string name, float weight, float price,int calories,  List<IngredientBase> ingredientlist)
        {
            this.DishId = dishId;
            this.Name = name;
            this.Weight = weight;
            this.Price = price;
            this.Calories = calories;
            this.IngredientsList = ingredientlist;

        }

        public DishBase( string dishId,string name, float weight,float price, List<IngredientBase> ingredientlist)
        {
            this.DishId = dishId;
            this.Name = name;
            this.Weight = weight;
            this.Price = price;
            this.IngredientsList = ingredientlist;
            
        }
        

        public string GetDishId()
        {
            return DishId;

        }
        //public void SetDishId(string dishid)
        //{
        //    DishId = dishid;

        //}


        
        public string GetDishName()
        {
            return Name;

        }

        //public void SetDishName(string dishname)
        //{
        //    Name = dishname;

        //}

        public float GetDishPrice()
        {

            return Price;

        }

        //public void SetDishPrice(float dishprice)
        //{
        //    Price = dishprice;

        //}


        public float GetDishWeight()
        {

            return Weight;

        }

        //public void SetDishWeight(float dishweight)
        //{
        //    Weight = dishweight;

        //}

    }
}
