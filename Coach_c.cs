using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y1S2
{
    internal class Coach_c
    {
        public static string coach_name;
        private string password;
        private string email;
        private string phoneNumber;
        private string level;
        private int salary;

        static SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["swimmingclubdb"].ToString());

        public Coach_c(string name, string pass, string emailadd, string phone_Number, string c_level)
        {
            coach_name = name;
            password = pass;
            email = emailadd;
            phoneNumber = phone_Number;
            level = c_level;
        }

        // Add couch
        public string addCoach()
        {
            string status;

            connect.Open();
            // Check account is registered
            string query = "select count(*) from users where username = @u";
            SqlCommand check = new SqlCommand(query, connect);
            check.Parameters.AddWithValue("@u", coach_name);
            int count = Convert.ToInt32(check.ExecuteScalar());
            if (count > 0)
            {
                status = "This account already exist, pls create a new one or login instead";
            }
            else
            {
                // Add to couch
                string query2 = "insert into coach (name, email, phoneNumber, level, salary_RM) values (@coachName, @email, @phoneNumber, @level, @salary)";
                SqlCommand cmd = new SqlCommand(query2, connect);
                cmd.Parameters.AddWithValue("@coachName", coach_name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@level", level);
                // Different level
                if (level == "begineer")
                {
                    salary = 1500;
                }
                else if (level == "intermediate")
                {
                    salary = 2000;
                }
                else if (level == "advance")
                {
                    salary = 2500;
                }
                cmd.Parameters.AddWithValue("@salary", salary);

                // Add to user
                string query3 = "insert into users (username, password, role) values (@name, @pass, 'coach')";
                SqlCommand cmd2 = new SqlCommand(query3, connect);
                cmd2.Parameters.AddWithValue("@name", coach_name);
                cmd2.Parameters.AddWithValue("@pass", password);

                cmd2.ExecuteNonQuery();
                int s = cmd.ExecuteNonQuery();
                if (s != 0)
                {
                    status = "Registration successfully.";
                }
                else
                {
                    status = "Unable to register.";
                }
            }
            connect.Close();
            return status;
        }
    }
}
