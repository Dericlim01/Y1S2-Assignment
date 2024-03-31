using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Y1S2
{
    internal class Schedule
    {
        public string Update(string date, string time, string level, string remarks)
        {
            string status = "";

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SwimmingClubConnectionString"].ToString()))
            {
                con.Open();

                string insertQuery = "INSERT INTO Schedule (date, time, level, remarks) VALUES (@Date, @Time, @Level, @Remarks)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.Parameters.AddWithValue("@Time", time);
                    cmd.Parameters.AddWithValue("@Level", level);
                    cmd.Parameters.AddWithValue("@Remarks", remarks);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        status = "Schedule edited successfully.";
                    }
                    else
                    {
                        status = "Failed to edit schedule.";
                    }
                }
            }

            return status;
        }

        public void LoadDataForEdit(int id, string datetimepicker, Control CBTime, Control CBLevel, string txtRemarks)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["SwimmingClubConnectionString"].ConnectionString))
            {
                cn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Schedule WHERE Id = @Id", cn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        datetimepicker.Text = reader["date"].ToString();
                        CBTime.Text = reader["Time"].ToString();
                        CBLevel.Text = reader["Level"].ToString();
                        txtRemarks.Text = reader["Remarks"].ToString();
                    }

                    reader.Close();
                }
            }
        }
    }
}
