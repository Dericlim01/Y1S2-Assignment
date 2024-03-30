using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Y1S2
{
    public partial class Member : Form
    {
        // Create a field for name
        public string name;
        public string role;

        public Member(string n, string r)
        {
            InitializeComponent();
            name = n;
            role = r;
        }

        // Constructor for login
        public Member(string n)
        {
            InitializeComponent();
            name = n;
        }

        // Initial display user profile
        private void Member_Load(object sender, EventArgs e)
        {
            lblname.Text = $"Name : {name}";
            lbltype.Text = $"Type : {role}";
        }

        private void edit_profile_btn_Click(object sender, EventArgs e)
        {
            Edit_Profile edit = new Edit_Profile(name, role);
            edit.ShowDialog();
        }
    }
}
