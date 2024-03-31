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
    public partial class ViewCompetition : Form
    {
        public string name;
        public string role;

        string comp_id;
        string comp_date;
        string comp_name;
        string comp_due_date;
        string comp_venue;
        string comp_details;

        public ViewCompetition()
        {
            InitializeComponent();
        }

        public ViewCompetition(string n, string r)
        {
            InitializeComponent();
            name = n;
            role = r;
        }

        private void competitionView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void competitionView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = competitionView.Rows[index];

            comp_id = $"{selectedRow.Cells[0].Value}";
            comp_name = $"{selectedRow.Cells[1].Value}";
            comp_date = $"{selectedRow.Cells[2].Value}";
            comp_due_date = $"{selectedRow.Cells[3].Value}";
            comp_venue = $"{selectedRow.Cells[4].Value}";
            comp_details = $"{selectedRow.Cells[5].Value}";

            // Display
            lblCompId.Text = comp_id;
            lblCompName.Text =comp_name;
            lblCompDate.Text =comp_date;
            lblDueDate.Text = comp_due_date;
            lblCompVenue.Text = comp_venue;
            lblCompDetails.Text = comp_details;
        }

        private void ViewCompetition_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'swimmingclubdbDataSet1.Competition' table. You can move, or remove it, as needed.
            this.competitionTableAdapter1.Fill(this.swimmingclubdbDataSet1.Competition);

        }

        private void bckBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Member back = new Member(name, role);
            back.ShowDialog();
        }
    }
}
