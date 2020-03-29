using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Login
    {
         string username;
         int password;

        public Login()
        {

        }

        public Login(string username, int password)
        {
            this.Username = username;
            this.Password = password;
        }

        public string Username { get => username; set => username = value; }
        public int Password { get => password; set => password = value; }
    }
}
