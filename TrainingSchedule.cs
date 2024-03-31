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
using Y1S2;

namespace Y1S2
{
    public partial class TrainingSchedule : Form
    {
        public TrainingSchedule()
        {
            InitializeComponent();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (scheduleDataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = scheduleDataGridView.SelectedRows[0].Index;
                int id = Convert.ToInt32(scheduleDataGridView.Rows[rowIndex].Cells[0].Value);

                scheduleDataGridView.Rows.RemoveAt(rowIndex);

                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["swimmingclubdb"].ConnectionString))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Schedule WHERE Id = @Id", cn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Row deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string Level = CBLevel.Text;
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["swimmingclubdb"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                using (DataTable dt = new DataTable("Orders"))
                {
                    using (SqlCommand cmd = new SqlCommand("select date, time, level, remarks from Schedule where date between @fromdate and @todate and Level = @Level", cn))
                    {
                        cmd.Parameters.AddWithValue("@fromdate", DTPickerFrom.Text);
                        cmd.Parameters.AddWithValue("@todate", DTPickerTO.Text);
                        cmd.Parameters.AddWithValue("@Level", Level);
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                        sqlDataAdapter.Fill(dt);
                        scheduleDataGridView.DataSource = dt;
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NextForm nextFormHandler = new NextForm();
            nextFormHandler.Next(this, new Coach());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NextForm nextFormHandler = new NextForm();
            nextFormHandler.Next(this, new AddSchedule());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (scheduleDataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = scheduleDataGridView.SelectedRows[0].Index;
                int id = Convert.ToInt32(scheduleDataGridView.Rows[rowIndex].Cells["Id"].Value);

                // Assuming you have controls (textboxes, etc.) to allow the user to edit data
                string newSchedule = txtNewSchedule.Text;
                // Get other edited data similarly

                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["swimmingclubdb"].ConnectionString))
                {
                    cn.Open();

                    // Update the row in the database
                    using (SqlCommand updateCmd = new SqlCommand("UPDATE Schedule SET Schedule = @Schedule WHERE Id = @Id", cn))
                    {
                        updateCmd.Parameters.AddWithValue("@Schedule", newSchedule);
                        updateCmd.Parameters.AddWithValue("@Id", id);
                        updateCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Row updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Refresh the DataGridView to reflect the changes
                LoadDataIntoDataGridView(); // Implement this method to reload data into the DataGridView
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ReadDataFromDatabase()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["swimmingclubdb"].ToString()))
            {
                con.Open();
                string query = "SELECT * FROM Schedule";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                scheduleDataGridView.DataSource = dataTable;
            }
        }

        private void btnDA_Click(object sender, EventArgs e)
        {
            ReadDataFromDatabase();
        }

        private void scheduleBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.scheduleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.swimmingclubdbDataSet1);

        }

        private void TrainingSchedule_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'swimmingclubdbDataSet1.Schedule' table. You can move, or remove it, as needed.
            this.scheduleTableAdapter.Fill(this.swimmingclubdbDataSet1.Schedule);

        }
    }
}
