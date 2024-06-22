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
    public partial class Edit_Profile : Form
    {
        private string name;
        private string role;
        private string abc;

        // Initialized
        public Edit_Profile(string n, string r)
        {
            InitializeComponent();
            name = n;
            role = r;

            // Hide label and textbox
            level_lbl.Hide();
            salary_lbl.Hide();
            level_txtbx.Hide();
            salary_txtbx.Hide();
            Coach_listbx.Hide();

            EditProfile load_p = new EditProfile();
            var data = load_p.load_profile(name, role);
            name_txtbx.Text = data.Item1;
            email_txtbx.Text = data.Item2;
            phoneNum_txtbx.Text = data.Item3;
        }

        // Update Profile Button
        private void update_btn_Click(object sender, EventArgs e)
        {
            string status;
            EditProfile update_p = new EditProfile();
            var num = update_p.update_profile(name_txtbx.Text, email_txtbx.Text, phoneNum_txtbx.Text, role);
            if (num != 0)
            {
                status = "Update Successfully.";
            }
            else
            {
                status = "Update failed.";
            }
            MessageBox.Show(status);
        }

        // ----- Coach -----
        // List Box
        public Edit_Profile(string n, string r, string a)
        {
            InitializeComponent();
            name = n;
            role = r;
            abc = a;

            EditProfile c_lsbox = new EditProfile();
            foreach (string item in c_lsbox.Coach_listbx())
            {
                Coach_listbx.Items.Add(item);
            }
        }

        // List Box selected
        private void Coach_listbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Coach_listbx.SelectedIndex != -1)
            {
                // Retrieve the selected item from the list box
                string selected_data = Coach_listbx.SelectedItem.ToString();

                EditProfile details = new EditProfile();
                var data = details.c_details(selected_data);
                name_txtbx.Text = data.Item1;
                email_txtbx.Text = data.Item2;
                phoneNum_txtbx.Text = data.Item3;
                level_txtbx.Text = data.Item4;
                salary_txtbx.Text = data.Item5;
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (role == "admin")
            {
                Admin back = new Admin(name, role);
                back.ShowDialog();
            }
            else if (role == "coach")
            {
                Coach back = new Coach();
                back.ShowDialog();
            }
            else if (role == "manager")
            {
                Manager back = new Manager(name, role);
                back.ShowDialog();
            }
            else if (role == "member")
            {
                Member back = new Member(name, role);
                back.ShowDialog();
            }
        }
    }
}
