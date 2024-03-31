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
    public partial class Admin : Form
    {
        public static string name;
        public static string role;
        public static string a;

        public Admin(string n, string r)
        {
            InitializeComponent();
            name = n;
            role = r;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            lblname.Text = $"Name : {name}";
            lbltype.Text = $"Type : {role}";
        }

        // Add Student
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddMember ad = new AddMember(name, role);
            ad.ShowDialog();
        }

        // Add Manager
        private void manager_add_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddManager add = new AddManager(name, role);
            add.ShowDialog();
        }

        // Add Couch
        private void couch_add_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCoach add = new AddCoach(name, role);
            add.ShowDialog();
        }

        // Edit Profile
        private void edit_profile_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Profile edit = new Edit_Profile(name, role);
            edit.ShowDialog();
        }

        // Edit Coach Profile
        private void coach_p_edit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Profile edit_couch = new Edit_Profile(name, role, a);
            edit_couch.ShowDialog();
        }

        private void manage_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_User delete_user = new Delete_User(name, role);
            delete_user.ShowDialog();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewTotalResult viewcomp = new viewTotalResult(name, role);
            viewcomp.ShowDialog();
        }
    }
}
