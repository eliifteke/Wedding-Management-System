using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;


namespace BLL
{
   public class Guests : MarriageWitness
    {
        int guestID;
        string name;
        string surname;
        string whosewedding;
        string weddingdate;
        string weddingvenue;

        public Guests()
        {

        }

        public Guests(int guestID, string name, string surname, string whosewedding, string weddingdate, string weddingvenue)
        {
            this.guestID = guestID;
            this.name = name;
            this.surname = surname;
            this.whosewedding = whosewedding;
            this.weddingdate = weddingdate;
            this.weddingvenue = weddingvenue;
        }

        public int GuestID { get => guestID; set => guestID = value; }
        public string Name1 { get => name; set => name = value; }
        public string Surname1 { get => surname; set => surname = value; }
        public string Whosewedding { get => whosewedding; set => whosewedding = value; }
        public string Weddingdate1 { get => weddingdate; set => weddingdate = value; }
        public string Weddingvenue1 { get => weddingvenue; set => weddingvenue = value; }


        //Misafirleri listeliyoruz
        public DataTable ListGuest()
        {
            try
            {
                string query = "select * from guest";
                DataAccess da = new DataAccess();
                return da.ExecuteQuery(query);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        //Misafirleri Ekliyor Tabloya
        public int AddGuest(Guests g)
        {
            try
            {
                string query = string.Format("INSERT INTO guest(name, surname, whosewedding, weddingdate, weddingvenue)" +
                    "VALUES('{0}','{1}','{2}','{3}','{4}')", g.Name, g.Surname, g.Whosewedding, g.Weddingdate, g.Weddingvenue);
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
