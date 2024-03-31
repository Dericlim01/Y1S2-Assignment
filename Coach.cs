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
    public partial class Coach : Form
    {
        public static string coach_name;
        public static string role;

        public Coach()
        {
            InitializeComponent();
        }

        // Create a constructor for login
        public Coach(string name, string r)
        {
            InitializeComponent();
            coach_name = name;
            role = r;
        }

        // Show details on the screen
        private void Coach_Load(object sender, EventArgs e)
        {
            lblname.Text = $"Name : {coach_name}";
            lbltype.Text = $"Type : {role}";
        }

        // Edit Profile Button
        private void edit_profile_btn_Click(object sender, EventArgs e)
        {
            Edit_Profile edit = new Edit_Profile(coach_name, role);
            edit.ShowDialog();
        }

        // Performance Button
        private void btnPfm_Click(object sender, EventArgs e)
        {
            NextForm nextFormHandler = new NextForm();
            nextFormHandler.Next(this, new Performance());
        }

        // Recommendation Button
        private void btnRcmd_Click(object sender, EventArgs e)
        {
            NextForm nextFormHandler = new NextForm();
            nextFormHandler.Next(this, new sendRecommendation());
        }

        // Training Schedule Button
        private void btnTrainSch_Click(object sender, EventArgs e)
        {
            NextForm nextFormHandler = new NextForm();
            nextFormHandler.Next(this, new TrainingSchedule());
        }
    }
}
