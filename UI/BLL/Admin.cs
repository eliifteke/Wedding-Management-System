using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using System.Data;


namespace BLL
{
    public class Admin : People
    {
        int adminID;
    

        public Admin()
        {

        }

        public Admin(int adminID, string name, string surname, string phonenumber, string email, string username, string password) :base( name, surname,  phonenumber,  email,  username,  password)
        {
            this.adminID = adminID;
        }

        public int AdminID { get => adminID; set => adminID = value; }


        //Admin girişi
        public override int Login(string username, string password)
        {
            string query = string.Format("SELECT * FROM admin WHERE " +
                "USERNAME ='{0}' AND PASSWORD='{1}'", username, password );

            DataAccess da = new DataAccess();
            DataTable dt = da.ExecuteQuery(query);

            if (dt.Rows.Count>0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            
        }


        //Adminleri listeleme
        public DataTable ListAdmin()
        {
            try
            {
                string query = "select * from admin";
                DataAccess da = new DataAccess();
               return da.ExecuteQuery(query);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //Admin Ekliyor Tabloya
        public int AddAdmin(Admin a)
        {
            try
            {
                string query = string.Format("INSERT INTO admin(name, surname, phonenumber, email, username, password)" +
                    "VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", a.Name, a.Surname, a.Phonenumber, a.Email, a.Username, a.Password  );
                DataAccess da = new DataAccess();
                return da.ExecuteNonQuery(query);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }




    }

    
}
