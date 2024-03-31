using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Y1S2
{
    internal class Recommendation
    {
        private string memberName;
        private string competitionId;
        private string details;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["swimmingclubdb"].ToString());


        public Recommendation(string mN, string iD, string dt)
        {
            memberName = mN;
            competitionId = iD;
            details = dt;
        }
        public Recommendation(string mN, string iD)
        {
            memberName = mN;
            competitionId = iD;
        }
        public Recommendation(string iD)
        {
            competitionId = iD;
        }




        public string sendRecommend()
        {
            string status;
            try
            {
                con.Open();

                string query1 = "SELECT competition_id FROM competition WHERE competition_id = @id ";
                string query2 = "SELECT name FROM member WHERE name = @name ";
                string query3 = "INSERT INTO Recommendation(competition_id,member_name,details) VALUES(@id, @name,@details) ";
                string queryCheck = "SELECT COUNT(*) FROM Recommendation WHERE competition_id = @id AND member_name = @name";

                SqlCommand cmd = new SqlCommand(query1, con);
                SqlCommand cmd2 = new SqlCommand(query2, con);
                SqlCommand cmd3 = new SqlCommand(query3, con);
                SqlCommand checkCmd = new SqlCommand(queryCheck, con);

                cmd.Parameters.AddWithValue("@id", competitionId);
                cmd2.Parameters.AddWithValue("@name", memberName);
                cmd3.Parameters.AddWithValue("@id", competitionId);
                cmd3.Parameters.AddWithValue("@name", memberName);
                cmd3.Parameters.AddWithValue("@details", details);
                checkCmd.Parameters.AddWithValue("@id", competitionId);
                checkCmd.Parameters.AddWithValue("@name", memberName);
                string id = (string)cmd.ExecuteScalar();
                competitionId = id;
                string member = (string)cmd2.ExecuteScalar();
                memberName = member;
                int count = (int)checkCmd.ExecuteScalar();
                if (count == 0)
                {
                    int i = cmd3.ExecuteNonQuery();

                    if (i != 0)
                    {
                        status = "Send Recommendation Successful.";
                    }
                    else
                    {
                        status = "Send Recommendation Fail";
                    }
                    con.Close();
                }
                else
                {
                    status = "Send Recommendation Fail, Recommendation Exist";
                }
            }

            catch (Exception ex)
            {
                status = "Send Recommendation Fail\nReason:" + ex.Message;
            }
            con.Close();
            return status;

        }


        public string getRecommendation()
        {

            con.Open();

            string query = "SELECT * FROM Recommendation WHERE competition_id = @id AND member_name = @name ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", competitionId);
            cmd.Parameters.AddWithValue("@name", memberName);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                con.Close();
                return rd.GetString(3);
            }
            else
            {
                con.Close();
                return null;
            }
        }

        public IEnumerable<string> recommendMemberList()
        {
            con.Open();
            string query = $"select member_name from Recommendation WHERE competition_id = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", competitionId);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                yield return rd.GetString(0);
            }
            con.Close();
        }
    }
}

    
