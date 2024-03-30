using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y1S2
{
    internal class DeleteUser
    {
        static SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["swimmingclubdb"].ToString());

        public DeleteUser()
        {
        }

        public IEnumerable<string> user(string u)
        {
            connect.Open();
            string query = $"select name from {u}";
            SqlCommand cmd = new SqlCommand(query, connect);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                yield return rd.GetString(0);
            }
            connect.Close();
        }

        public (string, string, string) u_details(string name, string role)
        {
            connect.Open();
            string query = $"select * from {role} where name = @name";
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@name", name);
            SqlDataReader rd = cmd.ExecuteReader();
            string n = "", e = "", pn = "";
            while (rd.Read())
            {
                n = rd.GetString(1);
                e = rd.GetString(2);
                pn = rd.GetString(3);
            }
            connect.Close();
            return (n, e, pn);
        }

        public int dlt_user(string n, string r)
        {
            connect.Open();
            // Search from role table
            string query = $"delete from {r} where name = @name";
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@name", n);
            // Search from users table
            string query2 = $"delete from users where username = @name";
            SqlCommand cmd2 = new SqlCommand(query2, connect);
            cmd2.Parameters.AddWithValue("@name", n);

            int i = cmd.ExecuteNonQuery();
            int j = cmd2.ExecuteNonQuery();
            connect.Close();
            return i + j;

        }
    }
}
