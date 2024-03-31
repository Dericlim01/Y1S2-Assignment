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
    public partial class EditSchedule : Form
    {
        public string name;
        public string role;
        int id;
        public EditSchedule()
        {
            InitializeComponent();
        }

        public EditSchedule(string n, string r)
        {
            InitializeComponent();
            name = n;
            role = r;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (scheduleDataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = scheduleDataGridView.SelectedRows[0].Index;
                id = Convert.ToInt32(scheduleDataGridView.Rows[rowIndex].Cells[0].Value);

                string date = dateTimePicker1.Text;
                string time = CBTime.Text;
                string level = CBLevel.Text;
                string remarks = txtRemarks.Text;

                if (string.IsNullOrWhiteSpace(date) || string.IsNullOrWhiteSpace(time) || string.IsNullOrWhiteSpace(level))
                {
                    MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["swimmingclubdb"].ToString()))
                {
                    cn.Open();

                    // Update the row in the database
                    using (SqlCommand updateCmd = new SqlCommand("UPDATE Schedule SET Date = @Date, Time = @Time, Level = @Level, Remarks = @Remarks WHERE id = @Id", cn))
                    {
                        updateCmd.Parameters.AddWithValue("@Id", id);
                        updateCmd.Parameters.AddWithValue("@Date", date);
                        updateCmd.Parameters.AddWithValue("@Time", time);
                        updateCmd.Parameters.AddWithValue("@Level", level);
                        updateCmd.Parameters.AddWithValue("@Remarks", remarks);
                        updateCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Row updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrainingSchedule traning_sche = new TrainingSchedule(name, role);
            traning_sche.ShowDialog();
        }

        // Data Grid View Content
        private void scheduleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.scheduleDataGridView.Rows[e.RowIndex];

                dateTimePicker1.Value = Convert.ToDateTime(row.Cells[1].Value);
                CBTime.Text = row.Cells[2].Value.ToString();
                CBLevel.Text = row.Cells[3].Value.ToString();
                txtRemarks.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
