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
    public partial class Manager : Form
    {
        public string name;
        public string role;
        public Manager(string n, string r)
        {
            InitializeComponent();
            name = n;
            role = r;
        }
        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            lblname.Text = $"Name : {name}";
            lbltype.Text = $"Type : {role}";
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Profile edit_p = new Edit_Profile(name, role);
            edit_p.ShowDialog();
        }

        private void compBtn_Click(object sender, EventArgs e)
        {
            ManagerCompetition Comp = new ManagerCompetition();
            Comp.Show();
            this.Hide();
            Comp.FormClosed += (s, args) => this.Close();
        }

        // Logout Button
        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.ShowDialog();
        }
    }
}
