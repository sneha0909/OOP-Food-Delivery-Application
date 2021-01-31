using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shukla_Project4
{
    public class Program
    {

        static void Main(string[] args)
        {

            DishBase MyDish = new DishBase();

            Order MyOrder = new Order();

            Order TrackMyOrder = new Order();



            var MenuforTako = new Menu();

            var MenuforDodo = new Menu();

            var MenuforNyam = new Menu();

            MainMenuPart2(MyOrder.MyCart, MyDish, MyOrder, TrackMyOrder, MenuforTako, MenuforDodo);


        }

        private static void Case1(List<DishBase> MyCart, DishBase MyDish, Order MyOrder, Order TrackMyOrder, Menu MenuforTako, Menu MenuforNyam)
        {
            var MenuforDodo = new Menu();

            MenuforDodo.AddDish(new DishBase("1", "Margarita Pizza", 620, 315,650, new List<IngredientBase>
                {
                new IngredientBase(IngredientType.Mozzarella_Cheese, 5),
                new IngredientBase(IngredientType.Tomato, 1),
                new IngredientBase(IngredientType.Italian_Herbs, 1),
                new IngredientBase(IngredientType.Tomato_Sauce, 1)
                }));


            MenuforDodo.AddDish(new DishBase("2", "Four Cheese Pizza", 540, 395,500, new List<IngredientBase>
               {
                new IngredientBase(IngredientType.Mozzarella_Cheese, 5),
                new IngredientBase(IngredientType.Cheddar_Cheese, 5),
                new IngredientBase(IngredientType.Cream_Sauce, 5),
                new IngredientBase(IngredientType.Blue_Cheese, 5)

               }));

            Console.WriteLine("DishId:" + MenuforDodo.Dishes[0].GetDishId() + "\nName:" + MenuforDodo.Dishes[0].GetDishName() + "\nWeight:" + MenuforDodo.Dishes[0].GetDishWeight() + "\nPrice:" + MenuforDodo.Dishes[0].GetDishPrice() + "\n\n");

            Console.WriteLine("DishId:" + MenuforDodo.Dishes[1].GetDishId() + "\nName:" + MenuforDodo.Dishes[1].GetDishName() + "\nWeight:" + MenuforDodo.Dishes[1].GetDishWeight() + "\nPrice:" + MenuforDodo.Dishes[1].GetDishPrice() + "\n\n");

            AddingToCartPart1(MyCart, MyDish, MyOrder, 1, TrackMyOrder, MenuforTako, MenuforDodo, MenuforNyam);


        }


        private static void AddingToCartPart1(List<DishBase> MyCart, DishBase MyDish, Order MyOrder, int Case, Order TrackMyOrder, Menu MenuforTako, Menu MenuforDodo, Menu MenuforNyam)
        {

            Console.WriteLine("Press DishId to add dish to your cart or Press any alphabet to go back to Main Menu\n");

            if (MyOrder.MyCart.Count == 0)
            {
                Console.WriteLine("----------------You have an EMPTY CART------------------ ");
            }
            else
            {
                Console.WriteLine("You have following dishes to your cart:\n");
                MyOrder.DisplayCart();
                MyOrder.SubTotal();
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Total Amount of Money to Pay:" + MyOrder.SubTotal() + " " + "Rubles\n");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Total Calories:" + MyOrder.CalculateCalories() + " " + "\n");
                Console.WriteLine("--------------------------------");


            }

            var UserInput = Console.ReadKey(); // get user input


            Console.WriteLine("\n");

            if (char.IsDigit(UserInput.KeyChar))
            {
                int ProductChosen = int.Parse(UserInput.KeyChar.ToString()) - 1;
                List<DishBase> DishList = new List<DishBase>();

                if (Case == 1)
                {
                    DishList = MenuforDodo.Dishes;



                    if (ProductChosen <= DishList.Count)
                    {

                        MyOrder.MyCart.Add(DishList[ProductChosen]);
                    }


                }

                else if (Case == 2)
                {
                    DishList = MenuforTako.Dishes;

                    if (ProductChosen <= DishList.Count)
                    {

                        MyOrder.MyCart.Add(DishList[ProductChosen]);
                    }
                }
                else if (Case == 3)
                {
                    DishList = MenuforNyam.Dishes;



                    if (ProductChosen <= DishList.Count)
                    {

                        MyOrder.MyCart.Add(DishList[ProductChosen]);
                    }
                }

                Console.WriteLine("Dish Added to Cart!\n");
                Console.WriteLine("You have following dishes to your cart:\n");

                MyOrder.DisplayCart();
                MyOrder.SubTotal();

                Console.WriteLine("--------------------------------");
                Console.WriteLine("Total Amount of Money to Pay:" + MyOrder.SubTotal() + " " + "Rubles\n");
                Console.WriteLine("--------------------------------");

                Console.WriteLine("To ADD dish to your cart press any alphabet, to REMOVE any dish from your cart press 1, to CREATE ORDER press 2 , to go back to MAIN MENU press 3");


                AddingToCartPart2(MyCart, MyDish, MyOrder, TrackMyOrder, MenuforTako, MenuforDodo, MenuforNyam);
            }

            else
            {
                MainMenu(MyCart, MyDish, MyOrder, TrackMyOrder, MenuforTako, MenuforDodo);
            }

        }

        private static void AddingToCartPart2(List<DishBase> MyCart, DishBase MyDish, Order MyOrder, Order TrackMyOrder, Menu MenuforTako, Menu MenuforDodo, Menu MenuforNyam)
        {
            int Bowl; // Variable to hold number


            var UserInput = Console.ReadKey(); // get user input

            Console.WriteLine("\n");

            if (char.IsDigit(UserInput.KeyChar))
            {

                Bowl = int.Parse(UserInput.KeyChar.ToString());

                if (Bowl == 2)
                {
                    CreateOrder(MyCart, MyDish, MyOrder, TrackMyOrder, MenuforTako, MenuforDodo);
                }


                else if (Bowl == 1)
                {

                    if (MyCart.Count == 0)
                    {
                        Console.WriteLine("You have an EMPTY CART!");


                    }
                    else
                    {
                        Console.WriteLine("\nEnter the DishID you want to remove from Cart");

                        var answer = Console.ReadLine();

                        int userinput = int.Parse(answer) - 1;
                        List<DishBase> DishList = new List<DishBase>();

                        DishList = MyCart;
                        if (userinput <= DishList.Count)
                        {

                            MyOrder.MyCart.Remove(DishList[userinput]);
                        }

                        Console.WriteLine("Dish REMOVED!:\n");
                        Console.WriteLine("Your Updated Cart:\n");

                        if (MyCart.Count == 0)
                        {

                            Console.WriteLine("-------------------------------You have an EMPTY CART-------------------------------------");
                            Console.WriteLine("Press any alphabet to go back to MAIN MENU");
                        }
                        else

                        {
                            MyOrder.DisplayCart();
                            MyOrder.SubTotal();
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine("Total Amount of Money to Pay:" + MyOrder.SubTotal() + " " + "Rubles\n");
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine("To ADD dish to your cart press any alphabet, to REMOVE any dish from your cart press 1, to CREATE ORDER press 2 , to go back to MAIN MENU press 3");

                            AddingToCartPart2(MyCart, MyDish, MyOrder, TrackMyOrder, MenuforTako, MenuforDodo, MenuforNyam);
                        }
                    }



                }

                else
                {
                    MainMenu(MyCart, MyDish, MyOrder, TrackMyOrder, MenuforTako, MenuforDodo);
                }


            }
            else
            {
                AddingToCartPart1(MyCart, MyDish, MyOrder, 1, TrackMyOrder, MenuforTako, MenuforDodo, MenuforNyam);

            }




        }

        private static void Case2(List<DishBase> MyCart, DishBase MyDish, Order MyOrder, Order TrackMyOrder, Menu MenuforTako, Menu MenuforDodo, Menu MenuforNyam)
        {
            Stock stockk = new Stock();
            var Menufortako = new Menu();

            Menufortako.AddDish(new DishBase("1", "Tori Yaki Chicken", 290, 179, new List<IngredientBase>
                {   new IngredientBase(IngredientType.Chicken, 5),
                    new IngredientBase(IngredientType.Rice, 2),
                    new IngredientBase(IngredientType.Onion, 1),
                    new IngredientBase(IngredientType.Sesame, 1)

                }));

            stockk.DecreaseFromStock(IngredientType.Chicken,5);
             

            Menufortako.AddDish(new DishBase("2", "Cantonese Pork", 290, 159, new List<IngredientBase>
                {   new IngredientBase(IngredientType.Minced_Pork, 20),
                    new IngredientBase(IngredientType.Rice, 12),
                    new IngredientBase(IngredientType.Egg, 1),
                    new IngredientBase(IngredientType.Red_Onion, 1),
                    new IngredientBase(IngredientType.Cream_Sauce, 2),
                    new IngredientBase(IngredientType.Onion, 1),
                    new IngredientBase(IngredientType.Sesame, 1)


                }));

            



            Console.WriteLine("DishId:" + Menufortako.Dishes[0].GetDishId() + "\nName:" + Menufortako.Dishes[0].GetDishName() + "\nWeight:" + Menufortako.Dishes[0].GetDishWeight() + "\nPrice:" + Menufortako.Dishes[0].GetDishPrice() + "\n\n");

            Console.WriteLine("DishId:" + Menufortako.Dishes[1].GetDishId() + "\nName:" + Menufortako.Dishes[1].GetDishName() + "\nWeight:" + Menufortako.Dishes[1].GetDishWeight() + "\nPrice:" + Menufortako.Dishes[1].GetDishPrice() + "\n\n");


            AddingToCartPart1(MyCart, MyDish, MyOrder, 2, TrackMyOrder, MenuforTako, MenuforDodo, MenuforNyam);
        }


        private static void Case3(List<DishBase> MyCart, DishBase MyDish, Order MyOrder, Order TrackMyOrder, Menu MenuforTako, Menu MenuforDodo)
        {
            var MenuforNyam = new Menu();

            MenuforNyam.AddDish(new DishBase("1", "Siberan Dumplings", 350, 179, new List<IngredientBase>
                {   new IngredientBase(IngredientType.Dough, 5),
                    new IngredientBase(IngredientType.Minced_Pork, 3),
                    new IngredientBase(IngredientType.Minced_Beef, 2),

                }));

            MenuforNyam.AddDish(new DishBase("2", "Chicken Kebab", 150, 229, new List<IngredientBase>
                {   new IngredientBase(IngredientType.Chicken, 8),
                    new IngredientBase(IngredientType.Lavash, 1),
                    new IngredientBase(IngredientType.Pickled_Onion, 1),

                }));

            Console.WriteLine("DishId:" + MenuforNyam.Dishes[0].GetDishId() + "\nName:" + MenuforNyam.Dishes[0].GetDishName() + "\nWeight:" + MenuforNyam.Dishes[0].GetDishWeight() + "\nPrice:" + MenuforNyam.Dishes[0].GetDishPrice() + "\n\n");

            Console.WriteLine("DishId:" + MenuforNyam.Dishes[1].GetDishId() + "\nName:" + MenuforNyam.Dishes[1].GetDishName() + "\nWeight:" + MenuforNyam.Dishes[1].GetDishWeight() + "\nPrice:" + MenuforNyam.Dishes[1].GetDishPrice() + "\n\n");




            AddingToCartPart1(MyCart, MyDish, MyOrder, 3, TrackMyOrder, MenuforTako, MenuforDodo, MenuforNyam);
        }


        private static void CreateOrder(List<DishBase> MyCart, DishBase MyDish, Order MyOrder, Order TrackMyOrder, Menu MenuforTako, Menu MenuforDodo)
        {

            Console.WriteLine("\nEnter the Customer Name");
            string name = Console.ReadLine();

            MyOrder.SetCustomerName(name);

            Console.WriteLine("Enter the Customer Address");
            string address = Console.ReadLine();

            MyOrder.SetCustomerAddress(address);

            Console.WriteLine("Enter the Customer Phone");
            string phone = Console.ReadLine();
            MyOrder.SetCustomerPhone(phone);

            Console.WriteLine("Enter the Customer Comment");
            string comment = Console.ReadLine();

            MyOrder.SetCustomerComment(comment);

            

            Console.WriteLine("Enter 1 to confirm order or 2 to go back to Main Menu");

            var command = Convert.ToInt32(Console.ReadLine());


            switch (command)
            {


                case 1:

                    Console.WriteLine("\nYour Order is created!");


                    string OrderNumber = MyOrder.orderId;

                    MyOrder.MyOrdersList.Add(OrderNumber);

                    MyOrder.DisplayOrders();

                    PrintOrder(MyCart, MyDish, MyOrder, TrackMyOrder, MenuforTako, MenuforDodo);

                 

                    break;

                case 2:

                    MainMenu(MyCart, MyDish, MyOrder, TrackMyOrder, MenuforTako, MenuforDodo);
                    break;


            }


        }



        private static void PrintOrder(List<DishBase> MyCart, DishBase MyDish, Order MyOrder, Order TrackMyOrder, Menu MenuforTako, Menu MenuforDodo)
        {
            string ss = "Retail Invoice";
            Console.SetCursorPosition((Console.WindowWidth - ss.Length) / 2, Console.CursorTop);
            Console.WriteLine(ss);


            Console.WriteLine("********************************************************************************************************************");

            Console.WriteLine("\nCustomer Name:" + MyOrder.GetCustomerName() + "\nCustomer Address:" + MyOrder.GetCustomerAddress() + "\nCustomer Phone:" + MyOrder.GetCustomerPhone() + "\n");

            Console.WriteLine("********************************************************************************************************************");


            Console.WriteLine("Sr     Product                                                                       Price");

            Console.WriteLine("********************************************************************************************************************");

            for (int i = 0; i < MyOrder.MyCart.Count; i++)
            {
                Console.WriteLine(i + 1 + "." + "     " + MyOrder.MyCart[i].GetDishName() + "                                                             " + MyOrder.MyCart[i].GetDishPrice());
            }

            Console.WriteLine("********************************************************************************************************************");


            Console.WriteLine("Total Quantity:" + MyOrder.MyCart.Count);
            Console.WriteLine("Total Amount:" + MyOrder.SubTotal() + " " + "Rubles");

            Console.WriteLine("\n");

            string sv = "Thankyou for Order! We hope to see you again!";
            Console.SetCursorPosition((Console.WindowWidth - sv.Length) / 2, Console.CursorTop);
            Console.WriteLine(sv);

            Console.WriteLine("********************************************************************************************************************");


            Console.WriteLine("Enter 1 to Track your Order or 2 to go back to Main Menu");

            ConsoleNotifier notifier = new ConsoleNotifier();
            var command = Convert.ToInt32(Console.ReadLine());

            switch (command)
            {
                case 1:

                    Console.WriteLine("Food Delivery Status");
                    Console.WriteLine("---------------------");

                    notifier.NotifyAboutEventByType(EventType.OrderReceived, $"Your Order is Received by the Restaurant! OrderId: {MyOrder.orderId}");
                    Thread.Sleep(1000);
                    notifier.NotifyAboutEventByType(EventType.OrderPreparation, $"Your Order is getting prepared! OrderId: {MyOrder.orderId}");
                    Thread.Sleep(1000);
                    notifier.NotifyAboutEventByType(EventType.OrderDispatched, $"Your Order is Dispatched! OrderId: {MyOrder.orderId}");
                    Thread.Sleep(1000);
                    notifier.NotifyAboutEventByType(EventType.OrderOntheWay, $"Your Order is On the Way! OrderId: {MyOrder.orderId}");
                    Thread.Sleep(1000);
                    notifier.NotifyAboutEventByType(EventType.OrderDelivered, $"Your Order is Delivered! OrderId: {MyOrder.orderId}");


                    Console.ReadKey();

                    Console.WriteLine("Press any key to go back to MAIN MENU");
                    break;

                case 2:
                    MainMenu(MyCart, MyDish, MyOrder, TrackMyOrder, MenuforTako, MenuforDodo);

                    break;

            }


        }




        private static void MainMenuPart2(List<DishBase> MyCart, DishBase MyDish, Order MyOrder, Order TrackMyOrder, Menu MenuforTako, Menu MenuforDodo)
        {
                string ss = "Welcome to Foodie Club \n";
                Console.SetCursorPosition((Console.WindowWidth - ss.Length) / 2, Console.CursorTop);
                Console.WriteLine(ss);


                Console.WriteLine("\n");

                var arrUsers = new Users[]
              {
                new Users("Sneha","0909","23/01/98",09),
                new Users("Victor","0909","09/10/1994",05),
                new Users("Alex","0202","09/11/1993",02)
              };

            Start:
                Console.WriteLine("To LOGIN press 1 OR to REGISTER press 2 OR if you are MANAGER press 3");
                var input = Console.ReadLine();


                bool successfull = false;
                while (!successfull)
                {

                    if (input == "1")
                    {
                        Console.WriteLine("Write your username:");
                        var username = Console.ReadLine();
                        Console.WriteLine("Enter your password:");
                        var password = Console.ReadLine();


                        foreach (Users user in arrUsers)
                        {
                            if (username == user.username && password == user.password)
                            {
                                Console.WriteLine("You have successfully logged in !!!");


                                MainMenu(MyCart, MyDish, MyOrder, TrackMyOrder, MenuforTako, MenuforDodo);


                                Console.ReadLine();
                                successfull = true;

                                MainMenu(MyCart, MyDish, MyOrder, TrackMyOrder, MenuforTako, MenuforDodo);

                                break;
                            }
                        }

                        if (!successfull)
                        {
                            Console.WriteLine("Your username or password is incorect, try again !!!");
                        }

                    }

                    else if (input == "2")
                    {
                        

                        Console.WriteLine("Enter your username:");
                        var username = Console.ReadLine();

                        Console.WriteLine("Enter your password:");
                        var password = Console.ReadLine();

                        Console.WriteLine("Enter your id:");
                        int id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter DOB (mm/dd/yyyy): ");
                        string birthday = Console.ReadLine();

                        


                    Array.Resize(ref arrUsers, arrUsers.Length + 1);
                        arrUsers[arrUsers.Length - 1] = new Users(username, password,birthday,id);
                        successfull = true;

                        Console.WriteLine("Congratulations !!!!! You have been Registered to Foodie Club!!! Please LOGIN with your credentials to use the services!");
                        goto Start;

                    }
                    else
                    {
                        Console.WriteLine("You are the Manager of the Foodie Club");

                        MainMenuPart3(MyCart, MyDish, MyOrder, TrackMyOrder, MenuforTako, MenuforDodo);


                        Console.WriteLine("Choose the Restaurant whose Menu you want to edit");


                        var command = Convert.ToInt32(Console.ReadLine());

                          switch(command)
                        {
                              case 1:
                                   Console.WriteLine("The current Menu of Dodo Pizza\n");
                                   Case1(MyCart, MyDish, MyOrder, TrackMyOrder, MenuforTako, MenuforDodo);

                                   Console.WriteLine("Enter the Dish Name you would like to add to the current Menu");
                                   var newdish = Console.ReadLine();

                                   Console.WriteLine("Current Orders :");
                                   MyOrder.DisplayOrders();

                                   DishBase dishh = new DishBase();

                                   dishh = (DishBase)MyDish;

                                   MenuforDodo.AddDish(dishh);

                                   Console.WriteLine("Dish Added to the Menu");

                                   break;

                              case 2:
                                   Case2(MyCart, MyDish, MyOrder, TrackMyOrder, MenuforTako, MenuforDodo, MenuforDodo);

                                   break;

                              case 3:

                                   Case3(MyCart, MyDish, MyOrder, TrackMyOrder, MenuforTako, MenuforDodo);
                                   break;

                        }



                         Console.ReadLine();
                          break;


                    }

                }

            
        }


            private static void MainMenu(List<DishBase> MyCart, DishBase MyDish, Order MyOrder, Order TrackMyOrder, Menu MenuforTako, Menu MenuforDodo)
       {
              MainMenuPart3(MyCart, MyDish, MyOrder, TrackMyOrder, MenuforTako, MenuforDodo);

            Console.WriteLine("Please select the Restaurants you want to order from OR Press 4 to View your Order");

            var command = Convert.ToInt32(Console.ReadLine());

            switch (command)
            {
                case 1:
                    Case1(MyCart, MyDish, MyOrder, TrackMyOrder, MenuforTako, MenuforDodo);


                    break;
                case 2:
                    Case2(MyCart, MyDish, MyOrder, TrackMyOrder, MenuforTako, MenuforDodo, MenuforDodo);

                    break;

                case 3:

                    Case3(MyCart, MyDish, MyOrder, TrackMyOrder, MenuforTako, MenuforDodo);
                    break;

                case 4:
                    if (MyOrder.MyOrdersList.Count == 0)
                    {
                        Console.WriteLine("----------------You have no Orders!------------------ \n");

                        Console.WriteLine("Press any number to go back to Main Menu\n");

                        int userrinput = 0;

                        while (!int.TryParse(Console.ReadLine(), out userrinput))
                        {
                            Console.WriteLine("Please Enter a valid input!");

                        }
                        MainMenu(MyCart, MyDish, MyOrder, TrackMyOrder, MenuforTako, MenuforDodo);

                    }
                    else
                    {
                        Console.WriteLine("You have following Orders:\n ");
                        MyOrder.DisplayOrders();
                        Console.WriteLine("Press 1 to go back to Main Menu\n");
                        MainMenu(MyCart, MyDish, MyOrder, TrackMyOrder, MenuforTako, MenuforDodo);

                    }

                    break;

            }

        }


        private static void MainMenuPart3(List<DishBase> MyCart, DishBase MyDish, Order MyOrder, Order TrackMyOrder, Menu MenuforTako, Menu MenuforDodo)
        {
            string ssx = "Welcome to Foodie Club \n";
            Console.SetCursorPosition((Console.WindowWidth - ssx.Length) / 2, Console.CursorTop);
            Console.WriteLine(ssx);


            Console.WriteLine("\n");


            var StockforDodo = new Stock()
            {
                IngredientsList = new List<IngredientBase>
                   {
                        new IngredientBase(IngredientType.Mozzarella_Cheese, 100),
                        new IngredientBase(IngredientType.Tomato, 50),
                        new IngredientBase(IngredientType.Italian_Herbs, 15),
                        new IngredientBase(IngredientType.Tomato_Sauce, 32),
                        new IngredientBase(IngredientType.Cheddar_Cheese, 11),
                        new IngredientBase(IngredientType.Cream_Sauce, 34),
                        new IngredientBase(IngredientType.Chicken, 150),
                        new IngredientBase(IngredientType.Pineapple, 11),
                        new IngredientBase(IngredientType.Ham, 45),
                        new IngredientBase(IngredientType.Mushroom, 50),
                        new IngredientBase(IngredientType.Spicy_Pepperoni, 11),
                        new IngredientBase(IngredientType.Meat_Sauce_Bolognese, 34),
                        new IngredientBase(IngredientType.Red_Onion, 50),
                        new IngredientBase(IngredientType.Dough, 50)
                   }
            };


            var StockforTako = new Stock()
            {
                IngredientsList = new List<IngredientBase>
                   {
                        new IngredientBase(IngredientType.Peking_Cabbage, 10),
                        new IngredientBase(IngredientType.Carrot, 2),
                        new IngredientBase(IngredientType.Radish, 15),
                        new IngredientBase(IngredientType.Fresh_cucumber, 32),
                        new IngredientBase(IngredientType.Mayonnaise, 11),
                        new IngredientBase(IngredientType.Onion, 34),
                        new IngredientBase(IngredientType.Sesame, 50),
                        new IngredientBase(IngredientType.Chinese_Cabbage, 11),
                        new IngredientBase(IngredientType.Tomato, 34),
                        new IngredientBase(IngredientType.Red_Onion, 50),
                        new IngredientBase(IngredientType.Egg, 11),
                        new IngredientBase(IngredientType.Soy_Sauce, 34),
                        new IngredientBase(IngredientType.Rice, 50),
                        new IngredientBase(IngredientType.Nori, 50),
                        new IngredientBase(IngredientType.Salmon, 11),
                        new IngredientBase(IngredientType.Curd_Cheese, 34),
                        new IngredientBase(IngredientType.Tortilla, 50),
                        new IngredientBase(IngredientType.Wheat_Noodles, 11),
                        new IngredientBase(IngredientType.Tempura_Flakes, 34),
                        new IngredientBase(IngredientType.Cheese_Balls, 50),
                        new IngredientBase(IngredientType.Cheese_Broth, 50)

                    }
            };

            var StockforNyam = new Stock()
            {
                IngredientsList = new List<IngredientBase>
                    {
                        new IngredientBase(IngredientType.Dough, 10),
                        new IngredientBase(IngredientType.Carmel_Onion, 2),
                        new IngredientBase(IngredientType.Lavash, 15),
                        new IngredientBase(IngredientType.Sour_Cream, 32),
                        new IngredientBase(IngredientType.Tomato, 11),
                        new IngredientBase(IngredientType.Chicken, 34),
                        new IngredientBase(IngredientType.Cheese_Tortilla, 50),
                        new IngredientBase(IngredientType.Mushroom, 11),
                        new IngredientBase(IngredientType.Hard_Cheese, 34),
                        new IngredientBase(IngredientType.Bell_Pepper, 50),
                        new IngredientBase(IngredientType.Minced_Beef, 11),
                        new IngredientBase(IngredientType.Minced_Pork, 34),
                        new IngredientBase(IngredientType.Fresh_cucumber, 50),
                        new IngredientBase(IngredientType.Feta_Cheese, 50),
                        new IngredientBase(IngredientType.Olives, 11),
                        new IngredientBase(IngredientType.Olive_oil, 34),
                        new IngredientBase(IngredientType.Pickled_Onion, 50),
                        new IngredientBase(IngredientType.Chinese_Cabbage, 11),
                        new IngredientBase(IngredientType.Carrot, 34),
                        new IngredientBase(IngredientType.Mozzarella_Cheese ,50),
                        new IngredientBase(IngredientType.Gouda_Cheese, 50),
                        new IngredientBase(IngredientType.Cheddar_Cheese, 50),
                        new IngredientBase(IngredientType.Blue_Cheese, 50),
                    }
            };

            var restaurant1 = new Restaurant(MenuforDodo, StockforDodo)
            {
                RestaurantId = "1",
                Name = "Dodo Pizza",
                Address = "Lenina Ulitsa 47, Tomsk 634050",
                Rating = 5

            };


            var restaurant2 = new Restaurant(MenuforDodo, StockforTako)
            {
                RestaurantId = "2",
                Name = "Mr Tako",
                Address = "Lenina Nokhanovicha 9",
                Rating = 4

            };

            var restaurant3 = new Restaurant(MenuforDodo, StockforNyam)
            {
                RestaurantId = "3",
                Name = "Nyam Nyam",
                Address = "Lenina Gagarina 1",
                Rating = 4

            };

            Console.WriteLine("ResaturantId:" + restaurant1.RestaurantId + "\nName:" + restaurant1.Name + "\nAddress:" + restaurant1.Address + "\nRating:" + restaurant1.Rating + "\n\n");

            Console.WriteLine("ResaturantId:" + restaurant2.RestaurantId + "\nName:" + restaurant2.Name + "\nAddress:" + restaurant2.Address + "\nRating:" + restaurant2.Rating + "\n\n");

            Console.WriteLine("ResaturantId:" + restaurant3.RestaurantId + "\nName:" + restaurant3.Name + "\nAddress:" + restaurant3.Address + "\nRating:" + restaurant3.Rating + "\n\n");




        }


    }
}
        
    
  


    

