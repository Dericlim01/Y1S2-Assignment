using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
        private string memberId;
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
        public Competition() { }
        public Competition(string c_id)
        {
            competitionId = c_id;
        }

        public string addCompetition()
        {
            string status;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Competition WHERE competition_id = @id", con);
                SqlCommand cmd2 = new SqlCommand("insert into competition(competition_id,competition_name,due_date,competition_date,venue,details) values(@id,@name,@cdate,@ddate,@ven,@dt)", con);

                cmd.Parameters.AddWithValue("@id", competitionId);
                cmd2.Parameters.AddWithValue("@id", competitionId);
                cmd2.Parameters.AddWithValue("@name", competitionName);
                cmd2.Parameters.AddWithValue("@cdate", competitionDate);
                cmd2.Parameters.AddWithValue("@ddate", dueDate);
                cmd2.Parameters.AddWithValue("@ven", venue);
                cmd2.Parameters.AddWithValue("@dt", details);
                int i = cmd2.ExecuteNonQuery();
                if (i != 0)
                {
                    status = "Registration Successful.";
                }
                else
                {
                    status = "Adding Competition Fail\nReason:";
                }
                con.Close();
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
            return status;
        }


        public string editCompetition()
        {
            string status;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Competition  SET competition_name = @name, due_date = @ddate, competition_date = @cdate,venue=@ven,details = @dt   WHERE competition_id = @id ", con);
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
                    status = "Edit Competition Fail\nReason:";
                }
                con.Close();
            }
            catch (SqlException ex)
            {
                status = "Edit Competition Fail\nReason:" + ex.Message;
            }
            catch (Exception ex)
            {
                status = "Edit Competition Fail\nReason:" + ex.Message;
            }
            return status;
        }


        public string deleteCompetition()
        {
            string status;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Competition  WHERE competition_id = @id ", con);
                cmd.Parameters.AddWithValue("@id", competitionId);

                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    status = "Delete Successfully.";
                }
                else
                {
                    status = "Delete Competition Fail\nReason:";
                }
                con.Close();
            }
            catch (SqlException ex)
            {
                status = "Delete Competition Fail\nReason:" + ex.Message;
            }
            catch (Exception ex)
            {
                status = "Delete Competition Fail\nReason:" + ex.Message;
            }
            return status;

        }
        
        public IEnumerable<string> memberlist()
        {
            con.Open();
            string query = $"select name from member";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                yield return rd.GetString(0);
            }
            con.Close();
        }
        public (string,string,string) findmember(string name)
        {
            con.Open();
            string query = $"select * from member where name = @name";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", name);
            SqlDataReader rd = cmd.ExecuteReader();
            string n = "", lvl = "",  age = "";
            while (rd.Read())
            {
                n = rd.GetString(1);
                lvl = rd.GetString(2);
                age = rd.GetString(3);
            }
            con.Close();
            return(n,lvl, age);

        }
    }
}