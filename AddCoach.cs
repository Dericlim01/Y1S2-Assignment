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
    public partial class AddCoach : Form
    {
        public AddCoach()
        {
            InitializeComponent();
        }

        string name;
        string role;
        public AddCoach(string n, string r)
        {
            InitializeComponent();
            name = n;
            role = r;
        }

        private void addcouch_btn_Click(object sender, EventArgs e)
        {
            Coach_c addcouch = new Coach_c(name_txtbx.Text, pass_txtbx.Text, email_txtbx.Text, phoneNum_txtbx.Text, lvl_txtbx.Text);
            MessageBox.Show(addcouch.addCoach());

            if (addcouch.addCoach() == "This account already exist, pls create a new one or login instead")
            {
                LoginPage login = new LoginPage();
                login.ShowDialog();
            }
        }

        // Back Button
        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin back = new Admin(name, role);
            back.ShowDialog();
        }
    }
}
