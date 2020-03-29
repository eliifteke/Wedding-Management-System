using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL; //Bunu kullanmayı unutma 

namespace BLL
{
    public abstract class People
    {
        string name;
        string surname;
        string phonenumber;
        string email;
        string username;
        string password;

        public People()
        {


        }

        public People(string name, string surname, string phonenumber, string email, string username, string password)
        {
            this.name = name;
            this.surname = surname;
            this.phonenumber = phonenumber;
            this.email = email;
            this.username = username;
            this.password = password;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }


        public abstract int Login(string username, string password);

        public void Logout()
        {

        }

        public List<string> ShowAnnouncement()
        {
            return null;
        }


    }
}
