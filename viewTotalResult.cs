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
    public partial class viewTotalResult : Form
    {
        private string name;
        private string role;

        public viewTotalResult()
        {
            InitializeComponent();
        }
        public viewTotalResult(string n, string r)
        {
            InitializeComponent();
            name = n;
            role = r;
        }
        

        private void viewTotalResult_Load(object sender, EventArgs e)
        {
            Competition compview = new Competition();
            int[] counts = compview.total();
            goldLbl.Text = counts[0].ToString();
            silverLbl.Text = counts[1].ToString();
            bronzeLbl.Text = counts[2].ToString();
            othersLbl.Text = counts[3].ToString();
        }

        private void bckBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin(name, role);
            admin.ShowDialog();

        }
    }
}
