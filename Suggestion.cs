using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y1S2
{
    internal class Suggestion
    {
        private string suggestion;
        static SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["swimmingclubdb"].ToString());
        public string Suggestions { get => suggestion; set => suggestion = value; }
        public static ArrayList viewAll()
        {
            ArrayList ls = new ArrayList();
            connect.Open();
            SqlCommand cmd = new SqlCommand("select * from suggestion", connect);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ls.Add(dr.GetString(0));
            }
            connect.Close();
            return ls;
        }
    }
}
