using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Y1S2
{
    internal class Member_c
    {
        // Create three private member field
        private string memName;
        private string password;
        private string email;
        private string phoneNum;
        private string lvl;
        static SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["swimmingclubdb"].ToString());

        public string Email { get => email; set => email = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }

        // Create a constructor
        public Member_c(string membername, string pass, string emailadd, string phonenumber, string level)
        {
            memName = membername;
            password = pass;
            email = emailadd;
            phoneNum = phonenumber;
            lvl = level;
        }

        public Member_c()
        {
        }

        // Add Member
        public string addMember()
        {
            string status;
            connect.Open();
            string query = "select count(*) from users where username = @name";
            SqlCommand check = new SqlCommand(query, connect);
            check.Parameters.AddWithValue("@name", memName);
            int count = Convert.ToInt32(check.ExecuteScalar());
            if (count > 0)
            {
                status = "This account already exist, pls create a new one or login instead";
            }
            else
            {
                // Insert data into student
                string query2 = "insert into member (name, email, phoneNumber, level) values (@name, @em, @num, @lvl)";
                SqlCommand cmd = new SqlCommand(query2, connect);
                cmd.Parameters.AddWithValue("@name", memName);
                cmd.Parameters.AddWithValue("@em", email);
                cmd.Parameters.AddWithValue("@num", phoneNum);
                cmd.Parameters.AddWithValue("@lvl", lvl);

                // Insert data into users
                string query3 = "insert into users (username, password, role) values (@name, @password, 'member')";
                SqlCommand cmd2 = new SqlCommand(query3, connect);
                cmd2.Parameters.AddWithValue("@name", memName);
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

        // View All member
        public static ArrayList viewAll()
        {
            ArrayList nm = new ArrayList();
            connect.Open();
            SqlCommand cmd = new SqlCommand("select name from member", connect);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(0)); // Add to arraylist
            }
            connect.Close();
            return nm;
        }

        public IEnumerable<string> memberlist()
        {
            connect.Open();
            string query = $"select name from member";
            SqlCommand cmd = new SqlCommand(query, connect);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                yield return rd.GetString(0);
            }
            connect.Close();
        }
        public (string, string, string, string) findMember(string name,string comp)
        {
            connect.Open();
            string query = "SELECT * FROM member WHERE name = @name";
            SqlCommand cmd = new SqlCommand(query, connect);

            cmd.Parameters.AddWithValue("@name", name);
            string n = "", lvl = "", age = "", rank = "";

            using (SqlDataReader rd = cmd.ExecuteReader())
            {
                if (rd.Read()) // Assuming you're interested in the first row only
                {
                    n = rd.GetString(1);  // Using indexer with column name for clarity
                    lvl = rd.GetString(4); // Assuming 'level' is the column name for lvl
                    age = rd.GetString(3); // Adjust according to your actual column name
                }
            } // DataReader is closed here

            string query2 = "SELECT ranking FROM competition_attend WHERE member_name = @name AND competition_id = @comp";
            SqlCommand cmd2 = new SqlCommand(query2, connect);
            cmd2.Parameters.AddWithValue("@name", name);
            cmd2.Parameters.AddWithValue("@comp", comp);
            object result = cmd2.ExecuteScalar(); // ExecuteScalar returns an object

            // Check if result is not null before casting
            if (result != null)
            {
                rank = result.ToString();
            }
            else
            {
                rank = "";
            }
                connect.Close();
            return (n, lvl, age, rank);
        }
    }
}
