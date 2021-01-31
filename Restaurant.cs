using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shukla_Project4
{
    public class Restaurant
    {
        public string RestaurantId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }
        public int Rating { get; set; }


        public Restaurant(Menu actualMenu, Stock actualStock)
        {
          

        }
        public string GetRestaurantId()
        {

            return RestaurantId;
        }

        public string GetRestaurantName()
        {

            return Name;
        }

        public string GetRestaurantAddress()
        {

            return Address;
        }

        public int GetRestaurantRating()
        {

            return Rating;
        }



    }
}
