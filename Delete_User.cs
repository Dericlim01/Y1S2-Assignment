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
    public partial class Delete_User : Form
    {
        public string name;
        public string role;
        public string user_role;
        public Delete_User()
        {
            InitializeComponent();
        }

        private void member_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            string member = "member";
            user_role = member;
            user_listbx.Items.Clear();
            DeleteUser deleteUser = new DeleteUser();
            foreach (string user in deleteUser.user(user_role))
            {
                user_listbx.Items.Add(user);
            }
        }

        private void manager_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            string mamager = "manager";
            user_role = mamager;
            user_listbx.Items.Clear();
            DeleteUser deleteUser = new DeleteUser();
            foreach (string user in deleteUser.user(user_role))
            {
                user_listbx.Items.Add(user);
            }
        }

        private void coach_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            string coach = "coach";
            user_role = coach;
            user_listbx.Items.Clear();
            DeleteUser deleteUser = new DeleteUser();
            foreach (string user in deleteUser.user(user_role))
            {
                user_listbx.Items.Add(user);
            }
        }

        private void user_listbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (user_listbx.SelectedIndex != -1)
            {
                string selected_data = user_listbx.SelectedItem.ToString();
                name = selected_data;

                DeleteUser deleteUser = new DeleteUser();
                var u_data = deleteUser.u_details(selected_data, user_role);
                name_lbl.Text = u_data.Item1;
                email_lbl.Text = u_data.Item2;
                phonenum_lbl.Text = u_data.Item3;
            }
        }

        private void dlt_btn_Click(object sender, EventArgs e)
        {
            string status;
            DeleteUser deleteUser = new DeleteUser();
            var num = deleteUser.dlt_user(name, user_role);
            if (num > 1)
            {
                status = "Delete Successfully.";
            }
            else
            {
                status = "Delete Failed.";
            }
            MessageBox.Show(status);

            // Return back to default
            name_lbl.Text = string.Empty;
            email_lbl.Text = string.Empty;
            phonenum_lbl.Text = string.Empty;
            user_listbx.Items.Clear();
            member_rdbtn.Checked = false;
            manager_rdbtn.Checked = false;
            coach_rdbtn.Checked = false;
        }

        public Delete_User(string n, string r)
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
    }
}
