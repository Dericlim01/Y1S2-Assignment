using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myDB"].ToString());

        public Competition(string c_id, string c_name, string c_date, string d_d, string v, string dt)
        {
            competitionId = c_id;
            competitionName = c_name;
            competitionDate = c_date;
            dueDate = d_d;
            venue = v;
            details = dt;

        }

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
                    status = "Registration Successful.";
                else
                    status = "Adding Competition Fail\nReason:";
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
                    status = "Registration Successful.";
                else
                    status = "Adding Competition Fail\nReason:";
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
    }

    

}
