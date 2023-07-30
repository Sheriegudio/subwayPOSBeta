using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SubwayPOS
{
    public class Model
    {
        public static string connectionString = "Data Source=DESKTOP-H6LMUBJ;Initial Catalog=Subway;Integrated Security=True";
        public static SqlConnection con;
        public static SqlDataReader authenticateUser(int userId, int passWord)
        {
            //opening conncetion
            openConnection();

            //logic for autnemtication
            string authenticationQurery = $"SELECT USERID, USERNAME, PASSWORD FROM USERS WHERE USERID = {userId} AND PASSWORD = {passWord}";
            SqlCommand cmd = new SqlCommand(authenticationQurery, con);
            cmd.Parameters.AddWithValue("ID", userId);
            cmd.Parameters.AddWithValue("PASSWORD", passWord);
            SqlDataReader reader = cmd.ExecuteReader();
            
            //closing connection
            return reader;
        }

        public static SqlDataReader insertUser(int userId, int passWord, String userName)
        {
            //opening conncetion
            openConnection();

            //logic for autnemtication
            string authenticationQurery = $"insert into USERS (USERID,PASSWORD,USERNAME) VALUES(@ID,@PASSWORD,@USERNAME)";
            SqlCommand cmd = new SqlCommand(authenticationQurery, con);
            cmd.Parameters.AddWithValue("ID", userId);
            cmd.Parameters.AddWithValue("PASSWORD", passWord);
            cmd.Parameters.AddWithValue("USERNAME", userName);
            SqlDataReader reader = cmd.ExecuteReader();

            //closing connection
            return reader;
        }

        public static void openConnection()
        {
            con = new SqlConnection(connectionString);
            con.Open();
        }

        public static void closeConnection()
        { 
            con.Close();
        }
    }
}
