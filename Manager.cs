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

        // Display name and role
        private void Manager_Load(object sender, EventArgs e)
        {
            lblname.Text = $"Name : {name}";
            lbltype.Text = $"Type : {role}";
        }

        // Edit Profile Button
        private void profileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Profile edit_p = new Edit_Profile(name, role);
            edit_p.ShowDialog();
        }

        private void compBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerCompetition Comp = new ManagerCompetition(name, role);
            Comp.ShowDialog();
        }

        // Logout Button
        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.ShowDialog();
        }

        private void memberListBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewCompetitor view = new ViewCompetitor(name, role);
            view.ShowDialog();
        }

        private void assBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssignCompetition assign = new AssignCompetition(name, role);
            assign.ShowDialog();
        }

        private void resultBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecordResult result = new RecordResult(name, role);
            result.ShowDialog();
        }

        private void listFromCoachBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            getRecommendation get_r = new getRecommendation(name, role);
            get_r.ShowDialog();
        }
    }
}
