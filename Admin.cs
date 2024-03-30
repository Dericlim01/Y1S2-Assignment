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

        public Admin(string n, string r)
        {
            InitializeComponent();
            name = n;
            role = r;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            lblidentity.Text = $"Hello, {name}";
        }

        // Add Student
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddMember ad = new AddMember();
            ad.ShowDialog();
        }

        // Add Couch
        private void couch_add_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCoach add = new AddCoach();
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
            Edit_Profile edit_couch = new Edit_Profile();
            edit_couch.ShowDialog();
        }

        private void manage_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_User delete_user = new Delete_User();
            delete_user.ShowDialog();
        }


    }
}
