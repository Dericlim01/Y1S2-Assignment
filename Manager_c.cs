using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y1S2
{
    internal class Manager_c
    {
        private string name;
        private string password;
        private string email;
        private string phoneNumber;

        static SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["swimmingclubdb"].ToString());

        public Manager_c(string n, string pass, string e, string phonenumber)
        {
            name = n;
            password = pass;
            email = e;
            phoneNumber = phonenumber;
        }

        public string addManager()
        {
            string status;
            connect.Open();
            string query = "select count(*) from users where username = @name";
            SqlCommand check = new SqlCommand(query, connect);
            check.Parameters.AddWithValue("@name", name);
            int count = Convert.ToInt32(check.ExecuteScalar());
            if (count > 0)
            {
                status = "This account already exist, pls create a new one or login instead";
            }
            else
            {
                // Insert data into student
                string query2 = "insert into manager (name, email, phoneNumber) values (@name, @em, @num)";
                SqlCommand cmd = new SqlCommand(query2, connect);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@em", email);
                cmd.Parameters.AddWithValue("@num", phoneNumber);

                // Insert data into users
                string query3 = "insert into users (username, password, role) values (@name, @password, 'manager')";
                SqlCommand cmd2 = new SqlCommand(query3, connect);
                cmd2.Parameters.AddWithValue("@name", name);
                cmd2.Parameters.AddWithValue("@password", password);

                int i = cmd.ExecuteNonQuery();
                int j = cmd2.ExecuteNonQuery();
                if (i + j == 2)
                {
                    status = "Registration Successful.";
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
