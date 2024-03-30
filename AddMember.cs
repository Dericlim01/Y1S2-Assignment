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
    public partial class AddMember : Form
    {
        // Member level
        string user_role;
        public AddMember()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string stat;
            Member_c obj1 = new Member_c(txtName.Text, txtPassword.Text, txtEmail.Text, txtPhone.Text, user_role);
            stat = obj1.addMember();

            // Set to empty
            txtName.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtPhone.Text = String.Empty;
            b_rdbtn.Checked = false;
            i_rdbtn.Checked = false;
            b_rdbtn.Checked = false;

            MessageBox.Show(stat);
        }

        string name;
        string role;
        public AddMember(string n, string r)
        {
            InitializeComponent();
            name = n;
            role = r;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin back = new Admin(name, role);
            back.ShowDialog();
        }

        private void b_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            user_role = "begineer";
        }

        private void i_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            user_role = "intermediate";
        }

        private void a_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            user_role = "advance";
        }
    }
}
