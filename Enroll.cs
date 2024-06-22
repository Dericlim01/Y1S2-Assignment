using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Y1S2
{
    public partial class Enroll : Form
    {
        public string level;
        public Enroll()
        {
            InitializeComponent();
        }

        public void load(string name, string password, string re_en_pass, string phoneNumber, string email, string level)
        {
            name_txtbx.Text = name;
            password_txtbx.Text = password;
            reenter_pass_txtbx.Text = re_en_pass;
            pn_txtbx.Text = phoneNumber;
            email_txtbx.Text = email;

            // Button Check
            if (level == "begineer")
            {
                b_rdbtn.Checked = true;
            }
            else if (level == "intermediate")
            {
                i_rdbtn.Checked = true;
            }
            else if (level == "advance")
            {
                b_rdbtn.Checked = true;
            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            Enrollment enrollment = new Enrollment();
            enrollment.update_profile(name_txtbx.Text, password_txtbx.Text, reenter_pass_txtbx.Text, pn_txtbx.Text, email_txtbx.Text, level);
        }

        private void b_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            level = "beginner";
        }

        private void i_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            level = "intermidiate";
        }

        private void a_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            level = "advance";
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.ShowDialog();
        }
    }
}
