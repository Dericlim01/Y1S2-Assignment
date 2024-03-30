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
    public partial class Unenroll : Form
    {
        public Unenroll()
        {
            InitializeComponent();
            dlt_btn.Hide();
        }

        private void srch_btn_Click(object sender, EventArgs e)
        {
            Enrollment srch = new Enrollment();
            var data = srch.search_member(name_txtbx.Text, password_txtbx.Text, reenter_pass_txtbx.Text);
            pn_lbl.Text = data.Item1;
            age_lbl.Text = data.Item2;
            email_lbl.Text = data.Item3;
            lvl_lbl.Text = data.Item4;
            dlt_btn.Show();
        }

        private void dlt_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Enrollment dlt = new Enrollment();
            dlt.dlt_member(name_txtbx.Text);

            LoginPage login = new LoginPage();
            login.ShowDialog();
        }
    }
}
