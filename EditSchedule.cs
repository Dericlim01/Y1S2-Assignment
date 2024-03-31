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
        public EditSchedule()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NextForm nextFormHandler = new NextForm();
            nextFormHandler.Next(this, new Coach());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (scheduleDataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = scheduleDataGridView.SelectedRows[0].Index;
                int id = Convert.ToInt32(scheduleDataGridView.Rows[rowIndex].Cells["Id"].Value);

                // Assuming you have controls (textboxes, etc.) to allow the user to edit data
                string newSchedule = txtNewSchedule.Text;
                // Get other edited data similarly

                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["SwimmingClubConnectionString"].ConnectionString))
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
    }
}
