using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        public void userlog(int userid)
        {
            //Users_userId
            conn.Open();
            cmd.Connection = conn;
            cmd.Parameters.Clear();
            cmd.CommandText = "INSERT INTO userlogs( Users_userId, timestamp) VALUES (@userid, @date); ";

            cmd.Parameters.AddWithValue("@userid", userid);
            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));

            int i = 0;
            try
            {
                i = cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                i = 0;
            }
            finally { conn.Close(); }

        }

        public void addcoursegrade(int userid, int courseid, int grade)
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.Parameters.Clear();
            cmd.CommandText = "insert into coursegrades(users_userid, courses_courseid, grade, timestamp) values (@userid, @courseid, @grade, @date); ";

            cmd.Parameters.AddWithValue("@userid", userid);
            cmd.Parameters.AddWithValue("@courseid", courseid);
            cmd.Parameters.AddWithValue("@grade", grade);
            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public void addprofessiongrade(int userid, int courseid, int grade)
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.Parameters.Clear();
            cmd.CommandText = "insert into professiongrades(users_userid, professions_professionid, grade, timestamp) values (@userid, @courseid, @grade, @date); ";

            cmd.Parameters.AddWithValue("@userid", userid);
            cmd.Parameters.AddWithValue("@courseid", courseid);
            cmd.Parameters.AddWithValue("@grade", grade);
            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public int getMaxCourseGrade(int userid, int courseid)
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.Parameters.Clear();
            cmd.CommandText = "select max(grade) from coursegrades where users_userid= @userid and Courses_courseId = @courseid;";

            cmd.Parameters.AddWithValue("@userid", userid);
            cmd.Parameters.AddWithValue("@courseid", courseid);

            var reader = cmd.ExecuteReader();

            int id = -1;

            while (reader.Read())
            {
                try
                {
                    id = reader.GetInt32(0);
                }
                catch(System.Data.SqlTypes.SqlNullValueException ex)
                {
                    id = 0;
                    break;
                }
                
            }
            conn.Close();

            return id;
        }

        public int getMaxCourseGrade(int userid)
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.Parameters.Clear();
            cmd.CommandText = "select max(grade) from coursegrades where users_userid= @userid;";

            cmd.Parameters.AddWithValue("@userid", userid);

            var reader = cmd.ExecuteReader();

            int id = -1;

            while (reader.Read())
            {
                try
                {
                    id = reader.GetInt32(0);
                }
                catch (System.Data.SqlTypes.SqlNullValueException ex)
                {
                    id = 0;
                    break;
                }

            }
            conn.Close();

            return id;
        }

        public string getlastlogin(int userid)
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.Parameters.Clear();
            cmd.CommandText = "select max(timestamp) from userlogs where users_userid= @userid;";

            cmd.Parameters.AddWithValue("@userid", userid);

            var reader = cmd.ExecuteReader();

            string s = "";

            while (reader.Read())
            {
                try
                {
                    s = reader.GetString(0);
                }
                catch (System.Data.SqlTypes.SqlNullValueException ex)
                {
                    break;
                }

            }
            conn.Close();

            return s;
        }

    }
}
