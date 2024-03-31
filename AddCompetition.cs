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
    public partial class AddCompetition : Form
    {
        public string name;
        public string role;

        public AddCompetition()
        {
            InitializeComponent();
        }

        public AddCompetition(string n, string r)
        {
            InitializeComponent();
            name = n;
            role = r;
        } 

        private void addCompbtn_Click(object sender, EventArgs e)
        {
            string formattedCompDate = addCompDate.Value.ToString("yyyy-MM-dd");
            string formattedDueDate = addDueDate.Value.ToString("yyyy-MM-dd");
            Competition comp1 = new Competition(addCompIdTB.Text, addCompNameTB.Text, formattedCompDate, formattedDueDate, addCompVenueTB.Text, addCompDetailTB.Text);
            MessageBox.Show(comp1.addCompetition());
        }

        private void bckBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerCompetition back = new ManagerCompetition(name, role);
            back.ShowDialog();
        }
    }
}
