using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Y1S2
{
    public partial class AddSchedule : Form
    {
        public string name;
        public string role;

        public AddSchedule()
        {
            InitializeComponent();
        }

        public AddSchedule(string n, string r)
        {
            InitializeComponent();
            name = n; role = r;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrainingSchedule training_sche = new TrainingSchedule(name, role);
            training_sche.ShowDialog();
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
