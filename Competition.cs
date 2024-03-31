using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Y1S2
{
    internal class Competition
    {
        private string competitionId;
        private string competitionName;
        private string competitionDate;
        private string dueDate;
        private string venue;
        private string details;
        private string memberName;
        private int ranking;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["swimmingclubdb"].ToString());

        public Competition(string c_id, string c_name, string c_date, string d_d, string v, string dt)
        {
            competitionId = c_id;
            competitionName = c_name;
            competitionDate = c_date;
            dueDate = d_d;
            venue = v;
            details = dt;
        }

        public Competition(string c_id, string mN, int rank)
        {
            competitionId = c_id;
            memberName = mN;
            ranking = rank;
        }

        public Competition() { }
        public Competition(string c_id)
        {
            competitionId = c_id;
        }

        public Competition(string c_id, string mN)
        {
            competitionId = c_id;
            memberName = mN;
        }

        public string addCompetition()
        {
            string status;
            con.Open();
            try
            {
                string query = "INSERT INTO competition (competition_id, competition_name, due_date, competition_date, venue,details) VALUES (@id, @name, @cdate, @ddate, @ven, @dt)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", competitionId);
                cmd.Parameters.AddWithValue("@name", competitionName);
                cmd.Parameters.AddWithValue("@cdate", competitionDate);
                cmd.Parameters.AddWithValue("@ddate", dueDate);
                cmd.Parameters.AddWithValue("@ven", venue);
                cmd.Parameters.AddWithValue("@dt", details);
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    status = "Registration Successful.";
                }
                else
                {
                    status = "Adding Competition Fail.";
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    status = "Adding Competition Failed, Competition ID exists.";
                }
                else
                {
                    status = "Adding Competition Fail\nReason:" + ex.Message;
                }
            }
            catch (Exception ex)
            {
                status = "Adding Competition Fail\nReason:" + ex.Message;
            }
            con.Close();
            return status;
        }


        public string editCompetition()
        {
            string status;
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Competition SET competition_name = @name, due_date = @ddate, competition_date = @cdate,venue=@ven,details = @dt WHERE competition_id = @id ", con);
                cmd.Parameters.AddWithValue("@id", competitionId);
                cmd.Parameters.AddWithValue("@name", competitionName);
                cmd.Parameters.AddWithValue("@cdate", competitionDate);
                cmd.Parameters.AddWithValue("@ddate", dueDate);
                cmd.Parameters.AddWithValue("@ven", venue);
                cmd.Parameters.AddWithValue("@dt", details);
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    status = "Edit Successfully.";
                }
                else
                {
                    status = "Edit Competition Fail";
                }
            }
            catch (SqlException ex)
            {
                status = "Edit Competition Fail\nReason:" + ex.Message;
            }
            catch (Exception ex)
            {
                status = "Edit Competition Fail\nReason:" + ex.Message;
            }
            con.Close();
            return status;
        }


        public string deleteCompetition()
        {
            string status;
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Competition  WHERE competition_id = @id ", con);
                cmd.Parameters.AddWithValue("@id", competitionId);

                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    status = "Delete Successfully.";
                }
                else
                {
                    status = "Delete Competition Fail";
                }
            }
            catch (SqlException ex)
            {
                status = "Delete Competition Fail\nReason:" + ex.Message;
            }
            catch (Exception ex)
            {
                status = "Delete Competition Fail\nReason:" + ex.Message;
            }
            con.Close();
            return status;

        }

        public IEnumerable<string> compList()
        {
            con.Open();
            string query = $"SELECT competition_name FROM competition";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                yield return rd.GetString(0);
            }
            con.Close();
        }

        public (string, string, string, string) findCompetition(string compName)
        {
            con.Open();
            string query = $"SELECT * FROM competition WHERE competition_name = @name";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", compName);
            SqlDataReader rd = cmd.ExecuteReader();
            string id = "", n = "", date = "", venue = "";
            while (rd.Read())
            {
                id = rd.GetString(0);
                n = rd.GetString(1);
                DateTime dateTime = rd.GetDateTime(3);
                date = dateTime.ToString("yyyy/MM/dd");
                venue = rd.GetString(4);
            }
            con.Close();
            return (id, n, date, venue);
        }



        public string assign_member()
        {
            string status;
            con.Open();
            try
            {
                string query1 = "SELECT competition_id FROM competition WHERE competition_id = @id ";
                string query2 = "SELECT name FROM member WHERE name = @name ";
                string query3 = "INSERT INTO competition_attend(competition_id,member_name) VALUES(@id, @name) ";
                string queryCheck = "SELECT COUNT(*) FROM competition_attend WHERE competition_id = @id AND member_name = @name";

                SqlCommand cmd = new SqlCommand(query1, con);
                SqlCommand cmd2 = new SqlCommand(query2, con);
                SqlCommand cmd3 = new SqlCommand(query3, con);
                SqlCommand checkCmd = new SqlCommand(queryCheck, con);

                cmd.Parameters.AddWithValue("@ID", competitionId);
                cmd2.Parameters.AddWithValue("@name", memberName);
                cmd3.Parameters.AddWithValue("@id", competitionId);
                cmd3.Parameters.AddWithValue("@name", memberName);
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
                        status = "Assign Member Successful.";
                    }
                    else
                    {
                        status = "Assign Member Fail";
                    }
                }
                else
                {
                    status = "This Member already Assign in this competition";
                }
            }
            catch (Exception ex)
            {
                status = "Assign Member Fail\nReason:" + ex.Message;
            }
            con.Close();
            return status;
        }
        public IEnumerable<string> compMemberList()
        {
            con.Open();
            string query = $"select member_name from competition_attend WHERE competition_id = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", competitionId);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                yield return rd.GetString(0);
            }
            con.Close();
        }

        public string recordCompResult()
        {
            string status;
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE competition_attend  SET ranking = @rank WHERE competition_id = @id AND member_name = @name ", con);
                cmd.Parameters.AddWithValue("@id", competitionId);
                cmd.Parameters.AddWithValue("@name", memberName);
                cmd.Parameters.AddWithValue("@rank", ranking);
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    status = "Update Successfully.";
                }
                else
                {
                    status = "Update Result Fail";
                }
            }
            catch (SqlException ex)
            {
                status = "Update Result Fail\nReason:" + ex.Message;
            }
            catch (Exception ex)
            {
                status = "Update Result Fail\nReason:" + ex.Message;
            }
            con.Close();
            return status;
        }

        public int[] total()
        {
            con.Open ();
            string queryothers = "SELECT COUNT(ranking) FROM competition_attend WHERE ranking > 3 ";
            string querybronze = "SELECT COUNT(ranking) FROM competition_attend WHERE ranking = 3 ";
            string querysilver = "SELECT COUNT(ranking) FROM competition_attend WHERE ranking = 2 ";
            string querygold = "SELECT COUNT(ranking) FROM competition_attend WHERE ranking = 1 ";

            SqlCommand cmdothers = new SqlCommand(queryothers, con);
            SqlCommand cmdbronze = new SqlCommand(querybronze, con);
            SqlCommand cmdsilver = new SqlCommand(querysilver, con);
            SqlCommand cmdgold = new SqlCommand(querygold, con);

            int gold = (int)cmdgold.ExecuteScalar();
            int silver = (int)cmdsilver.ExecuteScalar();
            int bronze = (int)cmdbronze.ExecuteScalar();
            int others = (int)cmdothers.ExecuteScalar();

            con.Close();
            // Return an array containing the counts for gold, silver, bronze, and others
            return new int[] { gold, silver, bronze, others };
        }
    }
}