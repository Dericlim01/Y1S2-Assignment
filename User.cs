using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Y1S2
{
    internal class User
    {
        private string username;
        private string password;

        public User(string un, string ps)
        {
            username = un;
            password = ps;
        }

        public string login(string un)
        {
            string status = null;

            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["myDB"].ToString());
            connect.Open();

            // SQL command match user
            SqlCommand cmd = new SqlCommand("select count(*) from users where username = un and password = ps", connect);
            cmd.Parameters.AddWithValue("un", username);
            cmd.Parameters.AddWithValue("ps", password);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0) // If login success
            {
                // Check role
                SqlCommand cmd2 = new SqlCommand("select role from users where username = un and password = ps", connect);
                cmd2.Parameters.AddWithValue("un", username);
                cmd2.Parameters.AddWithValue("ps", password);

                // Execute the SQL command to return a value
                string user_role = cmd2.ExecuteScalar().ToString();

                // Login as admin
                if (user_role == "admin")
                {
                    // Redirect to Admin Page
                } 
                else if (user_role == "student") // Login as student
                {
                    // Redirect to Student Page
                }
            } else
            {
                status = "Incorrect username or password";
            }
            connect.Close();
            return status;
        }
    }
}
