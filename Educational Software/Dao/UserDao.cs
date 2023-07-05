using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Educational_Software.Dao
{
    public class UserDao
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;

        public UserDao() {
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            cmd = new MySql.Data.MySqlClient.MySqlCommand();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        }


        public bool register(string username, string password)
        {

            conn.Open();
            cmd.Connection = conn;
            cmd.Parameters.Clear();
            cmd.CommandText = "INSERT INTO Users( username, password) VALUES (@username, @password); ";

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            int i=0;
            try
            {
                i = cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                i = 0;
            }
            finally { conn.Close(); }


            if(i == 0)
            {
                return false;
            }
            
            return true;
        }


        public int login(string username, string password)
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.Parameters.Clear();
            cmd.CommandText = "select userid from users where username = @username and password=@password ;";

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            var reader = cmd.ExecuteReader();

            int id = -1;

            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            conn.Close();

            return id;
        }
    }
}
