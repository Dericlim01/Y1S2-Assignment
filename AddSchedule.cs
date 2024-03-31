using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Y1S2
{
    public partial class AddSchedule : Form
    {
        public AddSchedule()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NextForm nextFormHandler = new NextForm();
            nextFormHandler.Next(this, new TrainingSchedule());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Text;
            string time = CBTime.Text;
            string level = CBLevel.Text;
            string remarks = txtRemarks.Text;

            if (string.IsNullOrWhiteSpace(date) || string.IsNullOrWhiteSpace(time) || string.IsNullOrWhiteSpace(level))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Schedule updateDB = new Schedule();
            string status = updateDB.Update(date, time, level, remarks);

            MessageBox.Show(status, "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
