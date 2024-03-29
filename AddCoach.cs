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

        private void addcouch_btn_Click(object sender, EventArgs e)
        {
            Coach addcouch = new Coach(name_txtbx.Text, pass_txtbx.Text, email_txtbx.Text, phoneNum_txtbx.Text, lvl_txtbx.Text);
            MessageBox.Show(addcouch.addCoach());

            if (addcouch.addCoach() == "This account already exist, pls create a new one or login instead")
            {
                LoginPage login = new LoginPage();
                login.ShowDialog();
            }
        }
    }
}
