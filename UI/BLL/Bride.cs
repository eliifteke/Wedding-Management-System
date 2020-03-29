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
    public class Bride : People
    {

        int brideID;
        string groomname;
        string weddingdate;
        string weddingvenue;

        public Bride()
        {

        }

        public Bride(int brideID, string groomname, string weddingdate, string weddingvenue, string name, string surname, string phonenumber, string email, string username, string password) : base(name, surname, phonenumber, email, username, password)

        {

            this.brideID = brideID;
            this.groomname = groomname;
            this.weddingdate = weddingdate;
            this.weddingvenue = weddingvenue;
        }

        public int BrideID { get => brideID; set => brideID = value; }
        public string Groomname { get => groomname; set => groomname = value; }
        public string Weddingdate { get => weddingdate; set => weddingdate = value; }
        public string Weddingvenue { get => weddingvenue; set => weddingvenue = value; }



        //Bride girişi
        public override int Login(string username, string password)
        {
            string query = string.Format("SELECT * FROM bride WHERE " +
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

        //Brideları listeliyoruz
        public DataTable ListBride()
        {
            try
            {
                string query = "select * from bride";
                DataAccess da = new DataAccess();
                return da.ExecuteQuery(query);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        //Bride Güncelleme
        public int UpdateBride(Bride b)
        {
            try
            {
                string query = string.Format("UPDATE bride set name='{0}', surname='{1}', phonenumber='{2}', email='{3}', username='{4}', password='{5}', weddingdate='{6}', weddingvenue='{7}', groomsname='{8}'" +
                   "WHERE brideID={9}", b.Name, b.Surname, b.Phonenumber, b.Email, b.Username, b.Password, b.Weddingdate, b.Weddingvenue, b.Groomname, b.BrideID);
                DataAccess da = new DataAccess();
                return da.ExecuteNonQuery(query);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        //Bride Ekliyor Tabloya
        public int AddBride(Bride b)
        {
            try
            {
                string query = string.Format("INSERT INTO bride(name, surname, phonenumber, email, username, password, weddingdate, weddingvenue, groomsname)" +
                    "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", b.Name, b.Surname, b.Phonenumber, b.Email, b.Username, b.Password, b.Weddingdate, b.Weddingvenue, b.Groomname);
                DataAccess da = new DataAccess();
                return da.ExecuteNonQuery(query);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        //Brideları silme

        public int DeleteBride(int id)
        {
            try
            {
                string query = string.Format("DELETE FROM bride " +
                   "WHERE brideID={0}", id);
                DataAccess da = new DataAccess();
                return da.ExecuteNonQuery(query);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        public DataTable SearchBride(string query)
        {
            try
            {
                Bride b = new Bride();
                DataAccess da = new DataAccess();
                return da.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable SearchBrideByName(string name)
        {
            try
            {
                Bride b = new Bride();
                string query = string.Format("select * from bride where lower(name) LIKE '{0}%'", name);
                DataAccess da = new DataAccess();
                return da.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Bride SearchBridetByID(int ID)
        {
            try
            {
                Bride b = new Bride();
                string query = string.Format("select * from bride where studentID = {0}", ID);
                DataAccess da = new DataAccess();
                DataTable dt = da.ExecuteQuery(query);
                if (dt.Rows.Count > 0)
                {
                    b.BrideID = int.Parse(dt.Rows[0]["StudentID"].ToString());
                    b.Name = dt.Rows[0]["Name"].ToString();
                    b.Surname = dt.Rows[0]["Surname"].ToString();
                    b.Phonenumber = dt.Rows[0]["Phonenumber"].ToString();
                    b.Email = dt.Rows[0]["Email"].ToString();
                    b.Username = dt.Rows[0]["Username"].ToString();
                    b.Password = dt.Rows[0]["Password"].ToString();
                    b.Weddingdate = dt.Rows[0]["Weddingdate"].ToString();
                    b.Weddingvenue = dt.Rows[0]["Weddingvenue"].ToString();
                    b.Groomname = dt.Rows[0]["Groomname"].ToString();
                }
                return b;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }



        }

    }
}
