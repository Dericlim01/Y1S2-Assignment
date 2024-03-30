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
    public partial class AddManager : Form
    {
        string name;
        string role;
        public AddManager(string n, string r)
        {
            InitializeComponent();
            name = n;
            role = r;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string stat;
            Manager_c obj1 = new Manager_c(txtName.Text, txtPassword.Text, txtEmail.Text, txtPhone.Text);
            stat = obj1.addManager();

            // Set to empty
            txtName.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtPhone.Text = String.Empty;

            MessageBox.Show(stat);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin back = new Admin(name, role);
            back.ShowDialog();
        }
    }
}
