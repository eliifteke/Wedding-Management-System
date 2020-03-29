using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SQLite;


namespace DAL
{
    public class DataAccess
    {

        private string conString = " ";

        //connection

        private SQLiteConnection con = null;

        //executin SQL
        private SQLiteCommand cmd = null;

        public DataAccess()
        {
            conString = @"data source = C:\Users\elift\source\repos\UI\DAL\Db\person.db";
            con = new SQLiteConnection(conString);
            cmd = new SQLiteCommand(con);
        }
       
        public DataTable ExecuteQuery(string query)
        {
            try
            {
                con.Open();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;

                SQLiteDataAdapter ad = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();

                ad.Fill(dt);

                return dt;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message + "Error in ExecuteQuery");
            }
        }
        public int ExecuteNonQuery(string query)
        {
            try
            {
                con.Open();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;

                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + "Error in ExecuteNonQuery");
            }
        }
    }
}
