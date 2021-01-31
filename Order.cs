using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shukla_Project4
{
    public class Order
    {
        public List<DishBase> MyCart = new List<DishBase>();

        public List<string> MyOrdersList = new List<string>();

        //private string OrderId;
        private string CustomerName;
        private string CustomerAddress;
        private string CustomerPhone;
        private string CustomerComment;
        protected readonly string OrderID;


        public Order()
        {
          

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var stringChars = new char[8];
            Random r = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[r.Next(chars.Length)];
            }

            OrderID = new String(stringChars);


        }
        public Order(string customername, string customeraddress, string customerphone, string customercomment)
        {
            this.CustomerName = customername;
            this.CustomerAddress = customeraddress;
            this.CustomerPhone = customerphone;
            this.CustomerComment = customercomment;


            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var stringChars = new char[8];
            Random r = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[r.Next(chars.Length)];
            }

            OrderID = new String(stringChars);

        }

        public string orderId => OrderID;

        public string GetCustomerName()
        {
            return CustomerName;

        }
        public void SetCustomerName(string name)
        {
            CustomerName = name; 

        }
        public void SetCustomerAddress(string address)
        {
            CustomerAddress = address;

        }
        public void SetCustomerPhone(string customerphone)
        {
            CustomerPhone = customerphone;

        }
        public void SetCustomerComment(string comment)
        {
            CustomerComment = comment;

        }
        public string GetCustomerAddress()
        {
            return CustomerAddress;

        }

        public string GetCustomerPhone()
        {
            return CustomerPhone;

        }

        public string GetCustomerComment()
        {
            return CustomerComment;

        }


        public void DisplayCart()
        {
            for (int i = 0; i < MyCart.Count; i++)
            {
                Console.WriteLine("Dish Id: " + MyCart[i].GetDishId() + "\n" + "Dish Name: " + MyCart[i].GetDishName() + "\n" + "Dish Price: " + " " + MyCart[i].GetDishPrice() + "\n");
            }


        }

        public bool CheckforDiscount()
        {
            Users myuser = new Users();

            DateTime Bday = DateTime.Parse(myuser.birthday);

            if ( DateTime.Now.Day==Bday.Day && DateTime.Now.Month ==Bday.Month )
            {
                Console.WriteLine("-------------- Yayyyyyy!!!!!!!!!!!It's your Birthday. Foodie Club will make your Birthday Special by giving you 50% discount on your order-----------------");
                Console.WriteLine("Please proceed with your order details");
                return true;
            }
            Console.WriteLine("Sorry No discounts available for you today!!!!!");
            return false;
            


        }

        public void DisplayOrders()
        {
            for (int i = 0; i < MyOrdersList.Count; i++)
            {
                Console.WriteLine("OrderId:" + MyOrdersList[i] + " \n" + "Customer Name" + "\n" + GetCustomerName());


            }
            for(int i =0; i<MyCart.Count;i++)
            {

                Console.WriteLine("Ordered Dish:" + MyCart[i].GetDishName() + "\n" + "Ordered Dish Price:" + MyCart[i].GetDishPrice()+"\n");
            }
        }

        public float SubTotal()
        {

            bool var = true;

            var= CheckforDiscount();

            if(var==true)
            {
             
                       float TotalPrice = 0;

                       foreach (var i in MyCart)
                 {
                       TotalPrice += i.GetDishPrice();

                 }
                       float Discount = 50;
                       float AfterDiscount = TotalPrice - (TotalPrice * Discount / 100);
                       return AfterDiscount;

            }
            else
            {
                 float TotalPrice = 0;

                 foreach (var i in MyCart)
               {
                     TotalPrice += i.GetDishPrice();

               }
                  return TotalPrice;

            }

            

        }


        public int CalculateCalories()
        {
            int TotalCalories = 0;

            foreach (var i in MyCart)
            {
                TotalCalories += i.Calories;

            }
            return TotalCalories;


        }




        

        

    }

    
}
