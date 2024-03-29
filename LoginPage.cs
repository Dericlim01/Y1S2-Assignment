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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            // Create a status field
            string status;
            this.Hide();
            User login = new User(username_txtbx.Text, password_txtbx.Text);
            status = login.login(username_txtbx.Text);

            // If return status is not empty
            if (status == null)
            {
                MessageBox.Show(status);
            }
            this.Show();

            // Set textbox to empty
            username_txtbx.Text = String.Empty;
            password_txtbx.Text = String.Empty;
        }
    }
}
