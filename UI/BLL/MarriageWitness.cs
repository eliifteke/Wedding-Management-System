using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BLL
{
   public class MarriageWitness
    {
        string name;
        string surname;
        string from_who;
        string weddingdate;
        string weddingvenue;

        public MarriageWitness()
        {

        }

        public MarriageWitness(string name, string surname, string from_who, string weddingdate, string weddingvenue)
        {
            this.name = name;
            this.surname = surname;
            this.from_who = from_who;
            this.weddingdate = weddingdate;
            this.weddingvenue = weddingvenue;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string From_who { get => from_who; set => from_who = value; }
        public string Weddingdate { get => weddingdate; set => weddingdate = value; }
        public string Weddingvenue { get => weddingvenue; set => weddingvenue = value; }



        //Nikahşahidi ekleme 
        public int AddMarriageW(MarriageWitness m)
        {
            try
            {
                string query = string.Format("INSERT INTO marriagem(name, surname, fromwho, weddingdate, weddingvenue)" +
                    "VALUES('{0}','{1}','{2}','{3}','{4}')", m.Name, m.Surname, m.From_who, m.Weddingdate, m.Weddingvenue);
                DataAccess da = new DataAccess();
                return da.ExecuteNonQuery(query);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //Nikah şahitlerini listeliyoruz
        public DataTable ListMarriagew()
        {
            try
            {
                string query = "select * from marriagem";
                DataAccess da = new DataAccess();
                return da.ExecuteQuery(query);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }







    }
    
 

}
