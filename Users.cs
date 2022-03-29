using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shukla_Project4
{
    public class Users
    {

        public string username;
        public string password;
        public string birthday;
        private int id;


        public Users()
        {



        }


        public Users(string username, string password,string birthday, int id)
        {
            this.username = username;
            this.password = password;
            this.id = id;
            this.birthday = birthday;
        }
    }
}
