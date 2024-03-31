using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Y1S2
{
    public partial class Performance : Form
    {
        public Performance()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string events = txtEvent.Text;
            string time = txtTime.Text;
            string comments = txtComment.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(events) || string.IsNullOrWhiteSpace(time))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UpdateDB updateDB = new UpdateDB();
            string status = updateDB.Update(name, events, time, comments);

            MessageBox.Show(status, "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal class UpdateDB
        {

            public string Update(string Name, string Events, string Time, string Comments)
            {
                string status = "";

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SwimmingClubConnectionString"].ToString()))
                {
                    con.Open();

                    string insertQuery = "INSERT INTO Performance (Name, Event, Time, Comments) VALUES(@Name, @Event, @Time, @Comments)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@Event", Events);
                        cmd.Parameters.AddWithValue("@Time", Time);
                        cmd.Parameters.AddWithValue("@Comments", Comments);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            status = "Performance recorded successfully.";
                        }
                        else
                        {
                            status = "Failed to record Performance.";
                        }
                    }
                }

                return status;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NextForm nextFormHandler = new NextForm();
            nextFormHandler.Next(this, new Coach());
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            NextForm nextFormHandler = new NextForm();
            nextFormHandler.Next(this, new Coach());
        }
    }
}
