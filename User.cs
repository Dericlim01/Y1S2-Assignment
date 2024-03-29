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

            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["swimmingclubdb"].ToString());
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

                if (user_role == "admin") // Login as admin
                {
                    // Redirect to Admin Page
                    Admin admin = new Admin(un, user_role);
                    admin.ShowDialog();
                } 
                else if (user_role == "coach") // Login as coach
                {
                    // Redirect to Coach Page
                    Coach coach = new Coach();
                    coach.ShowDialog();
                }
                else if (user_role == "manager") // Login as manager
                {
                    // Redirect to Manager Page
                    Manager manager = new Manager();
                    manager.ShowDialog();
                }
                else if (user_role == "member") // Login as member
                {
                    // Redirect to Student Page
                    Member member = new Member(un);
                    member.ShowDialog();
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
