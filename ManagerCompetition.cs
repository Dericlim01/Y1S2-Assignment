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
    public partial class ManagerCompetition : Form
    {
        string comp_id;
        string comp_date;
        string comp_name;
        string comp_due_date;
        string comp_venue;
        string comp_details;

        public ManagerCompetition()
        {
            InitializeComponent();
        }

        private void AddCompetition_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'swimmingclubdbDataSet.Competition' table. You can move, or remove it, as needed.
            this.competitionTableAdapter.Fill(this.swimmingclubdbDataSet.Competition);
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
            lblCompId.Text = "Competition ID: "+ comp_id;
            lblCompName.Text = "Competition Name: " + comp_name;
            lblCompDate.Text = "Competition Date: " + comp_date;
            lblDueDate.Text = "Due Date: " + comp_due_date;
            lblCompVenue.Text = "Venue: " + comp_venue;
            lblCompDetails.Text = "Details: " + comp_details;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (comp_id != null && comp_id != "" && comp_id != " ")
            {
                Edit_Competition edit = new Edit_Competition(comp_id, comp_name, comp_date, comp_due_date,comp_venue,comp_details);
                edit.Show();
                this.Hide();
                edit.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Please Select A Row To Edit");
            }
                
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddCompetition add = new AddCompetition();
            add.Show();
            this.Close();
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            if (comp_id != null)
            {
                Competition comp3 = new Competition(comp_id);
                MessageBox.Show(comp3.deleteCompetition());
                ManagerCompetition Comp = new ManagerCompetition();
                Comp.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Select A Row To Delete");
            }
        }

        private void bckBtn_Click(object sender, EventArgs e)
        {
            Manager back = new Manager();
            back.Show();
            this.Close();
        }
    }
}
