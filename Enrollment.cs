using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Y1S2
{
    internal class Enrollment
    {
        static SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["swimmingclubdb"].ToString());
        public Enrollment()
        {
        }

        public void update_profile(string n, string p, string re_en, string pn, string e, string a, string l)
        {
            string status;
            connect.Open();

            // Chcek from member to avoid same username
            string query = "select name from member where name = @name";
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@name", n);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                MessageBox.Show("This Username has already taken");

                Enroll enroll = new Enroll();
                enroll.load(n, p, re_en, pn, e, a, l);
            } // If password not same
            else if (p != re_en)
            {
                MessageBox.Show("Please confirm your password");

                Enroll enroll = new Enroll();
                enroll.load(n, p, re_en, pn, e, a, l);
            }
            else // Insert user data
            {
                // Insert into member
                string query2 = "insert into member (name, phoneNumber, email, age, level) values (@name, @pn, @email, @age, @lvl)";
                SqlCommand cmd2 = new SqlCommand(query2, connect);
                cmd2.Parameters.AddWithValue("@name", n);
                cmd2.Parameters.AddWithValue("@pn", pn);
                cmd2.Parameters.AddWithValue("@email", e);
                cmd2.Parameters.AddWithValue("@age", a);
                cmd2.Parameters.AddWithValue("@lvl", l);

                // Insert into users
                string query3 = "insert into users (username, password, role) values (@name, @pass, 'member')";
                SqlCommand cmd3 = new SqlCommand(query3, connect);
                cmd3.Parameters.AddWithValue("@name", n);
                cmd3.Parameters.AddWithValue("@pass", p);

                int i = cmd.ExecuteNonQuery();
                int j = cmd.ExecuteNonQuery();
                if (i + j != 0)
                {
                    status = "Register Successfully";
                }
                else
                {
                    status = "Register Failed";
                }
                MessageBox.Show(status);
                connect.Close();
            }
        }

        public (string, string, string, string) search_member(string name, string pass, string re_en)
        {
            connect.Open();
            if (pass == re_en)
            {
                string query = "select * from users where username = @name and password = @pass";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@pass", pass);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    string query2 = "select * from member where name = @name";
                    SqlCommand cmd2 = new SqlCommand(query2, connect);
                    cmd2.Parameters.AddWithValue("@name", name);
                    SqlDataReader rd = cmd2.ExecuteReader();
                    string pn = "", age = "", e = "", lvl = "";
                    while (rd.Read())
                    {
                        pn = rd.GetString(3);
                        age = rd.GetString(4);
                        e = rd.GetString(2);
                        lvl = rd.GetString(5);
                    }
                    return (pn, age, e, lvl);
                }
                else
                {
                    return ("", "", "", "");
                }
            }
            else
            {
                return ("", "", "", "");
            }
        }

        public void dlt_member(string name)
        {
            string query = "delete from users where username = @name";
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@name", name);

            string query2 = "delete from member where name = @name";
            SqlCommand cmd2 = new SqlCommand(query2, connect);
            cmd.Parameters.AddWithValue("@name", name);

            int i = cmd.ExecuteNonQuery();
            int j = cmd2.ExecuteNonQuery();

            if (i + j > 1)
            {
                MessageBox.Show("User delete succesfully");
            }
            else
            {
                MessageBox.Show("User Delete unsuccessfull");
            }

        }
    }
}
