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
    public class Groom : People
    {
        int groomID;
        string bridename;
        string weddingdate;
        string weddingvenue;

        public Groom()
        {

        }

        public Groom(int groomID, string bridename, string weddingdate, string weddingvenue, string name, string surname, string phonenumber, string email, string username, string password) : base(name, surname, phonenumber, email, username, password)

        {
            this.groomID = groomID;
            this.bridename = bridename;
            this.weddingdate = weddingdate;
            this.weddingvenue = weddingvenue;
        }

        public int GroomID { get => groomID; set => groomID = value; }
        public string Bridename { get => bridename; set => bridename = value; }
        public string Weddingdate { get => weddingdate; set => weddingdate = value; }
        public string Weddingvenue { get => weddingvenue; set => weddingvenue = value; }


        //Groom girişi
        public override int Login(string username, string password)
        {
            string query = string.Format("SELECT * FROM groom WHERE " +
                "USERNAME ='{0}' AND PASSWORD='{1}'", username, password);

            DataAccess da = new DataAccess();
            DataTable dt = da.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        //Groomları listeliyoruz
        public DataTable ListGroom()
        {
            try
            {
                string query = "select * from groom";
                DataAccess da = new DataAccess();
                return da.ExecuteQuery(query);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        //Groom Ekliyor Tabloya
        public int AddGroom(Groom g)
        {
            try
            {
                string query = string.Format("INSERT INTO groom(name, surname, phonenumber, email, username, password, weddingdate, weddingvenue, bridesname)" +
                    "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", g.Name, g.Surname, g.Phonenumber, g.Email, g.Username, g.Password, g.Weddingdate, g.Weddingvenue, g.Bridename);
                DataAccess da = new DataAccess();
                return da.ExecuteNonQuery(query);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //Groom Güncelleme
        public int UpdateGroom(Groom g)
        {
            try
            {
                string query = string.Format("UPDATE groom set name='{0}', surname='{1}', phonenumber='{2}', email='{3}', username='{4}', password='{5}', weddingdate='{6}', weddingvenue='{7}', bridesname='{8}')" +
                   "WHERE groomID={9}", g.Name, g.Surname, g.Phonenumber, g.Email, g.Username, g.Password, g.Weddingdate, g.Weddingvenue, g.Bridename, g.GroomID);
                DataAccess da = new DataAccess();
                return da.ExecuteNonQuery(query);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        //Groomları silme

        public int DeleteGroom(int id)
        {
            try
            {
                string query = string.Format("DELETE FROM groom " +
                   "WHERE groomID={0}", id);
                DataAccess da = new DataAccess();
                return da.ExecuteNonQuery(query);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        public DataTable SearchGroom(string query)
        {
            try
            {
                Groom g = new Groom();
                DataAccess da = new DataAccess();
                return da.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public DataTable SearchGroomByName(string name)
        {
            try
            {
                Groom g = new Groom();
                string query = string.Format("select * from groom where lower(name) LIKE '{0}%'", name);
                DataAccess da = new DataAccess();
                return da.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Groom SearchGroomByID(int ID)
        {
            try
            {
                Groom g = new Groom();
                string query = string.Format("select * from groom where studentID = {0}", ID);
                DataAccess da = new DataAccess();
                DataTable dt = da.ExecuteQuery(query);
                if (dt.Rows.Count > 0)
                {
                    g.GroomID = int.Parse(dt.Rows[0]["groomID"].ToString());
                    g.Name = dt.Rows[0]["Name"].ToString();
                    g.Surname = dt.Rows[0]["Surname"].ToString();
                    g.Phonenumber = dt.Rows[0]["Phonenumber"].ToString();
                    g.Email = dt.Rows[0]["Email"].ToString();
                    g.Username = dt.Rows[0]["Username"].ToString();
                    g.Password = dt.Rows[0]["Password"].ToString();
                    g.Weddingdate = dt.Rows[0]["Weddingdate"].ToString();
                    g.Weddingvenue = dt.Rows[0]["Weddingvenue"].ToString();
                    g.Bridename = dt.Rows[0]["Bridename"].ToString();
                }
                return g;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }




        }

    }
}
