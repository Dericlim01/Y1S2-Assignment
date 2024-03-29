using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y1S2
{
    internal class Suggestions
    {
        static SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["myDB"].ToString());

        public Suggestions()
        {
        }

        public string send_suggest(string name, string suggest)
        {
            string status;
            connect.Open();
            // Insert data into 
            string query = "insert into suggestion (name, details) values (@name, @suggestion)";
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@suggestion", suggest);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Submit Successfully";
            }
            else
            {
                status = "Submit Failed";
            }
            connect.Close();
            return status;
        }

        public IEnumerable<string> member_search()
        {
            connect.Open();
            string query = "select name from member";
            SqlCommand cmd = new SqlCommand(query, connect);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                yield return rd.GetString(0);
            }
        }

        public IEnumerable<string> receive_suggest(string name)
        {
            connect.Open();
            string query = "select details from suggestions where name = @name";
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@name", name);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                yield return dr.GetString(0);
            }
        }
    }
}
