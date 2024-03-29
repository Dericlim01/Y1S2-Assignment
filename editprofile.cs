using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y1S2
{
    internal class EditProfile
    {
        static SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["myDB"].ToString());

        public EditProfile()
        {
        }

        // Initial load for display profile
        public (string, string, string) load_profile(string name, string role)
        {
            // Display Profile
            connect.Open();
            string query = $"select * from {role} where name = @name";
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@name", name);
            SqlDataReader dr = cmd.ExecuteReader();
            string n = "", e = "", pn = "";
            while (dr.Read())
            {
                n = dr.GetString(1);
                e = dr.GetString(2);
                pn = dr.GetString(3);
            }
            connect.Close();
            return (n, e, pn);
        }

        // Button click and update profile
        public int update_profile(string name, string email, string phoneNum, string role)
        {
            connect.Open();
            string query = $"update {role} set name = @newname, email = @email, phoneNumber = @phoneNum where name = @name";
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@newname", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phoneNum", phoneNum);

            int i = cmd.ExecuteNonQuery();
            connect.Close();
            return i;
        }

        // Load List Box
        public IEnumerable<string> Couch_listbx()
        {
            connect.Open();
            string query = "select name from couch";
            SqlCommand cmd = new SqlCommand(query, connect);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                // Store item into listbox
                yield return rd.GetString(0);
            }
            connect.Close();
        }

        // Display Coach Details
        public (string, string, string, string, string) c_details(string c_name)
        {
            connect.Open();
            // Selected items
            string query2 = "select * from couch where name = @name";
            SqlCommand cmd2 = new SqlCommand(query2, connect);
            cmd2.Parameters.AddWithValue("@name", c_name);
            SqlDataReader dr = cmd2.ExecuteReader();
            string n = "", e = "", pn = "", lvl = "", slr = "";
            while (dr.Read())
            {
                n = dr.GetString(1);
                e = dr.GetString(2);
                pn = dr.GetString(3);
                lvl = dr.GetString(4);
                slr = $"RM {dr.GetInt32(5)}";
            }
            connect.Close();
            return (n, e, pn, lvl, slr);
        }
    }
}
