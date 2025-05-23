﻿using System;
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
    public partial class sendRecommendation : Form
    {
        public string name;
        public string role;

        public sendRecommendation()
        {
            InitializeComponent();
        }

        public sendRecommendation(string n, string r)
        {
            InitializeComponent();
            name = n;
            role = r;
        }

        private void memberListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (memberListBox.SelectedIndex != -1)
            {
                // Retrieve the selected item from the list box
                string selected_member = memberListBox.SelectedItem.ToString();
                Member_c details = new Member_c();
                var data = details.findMember(selected_member, recommendCompIdlbl.Text);
                recommendMembNamelbl.Text = data.Item1;
                recommendMembLevellbl.Text = data.Item2;
            }
        }

        private void sendRecommendation_Load(object sender, EventArgs e)
        {
            Competition comp7 = new Competition();
            foreach (string comp in comp7.compList())
            {
                competitionListBox.Items.Add(comp);
            }
        }

        private void competitionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (competitionListBox.SelectedIndex != -1)
            {
                memberListBox.Items.Clear();
                // Retrieve the selected item from the list box
                string selected_competition = competitionListBox.SelectedItem.ToString();
                Competition details = new Competition();
                var data = details.findCompetition(selected_competition);
                recommendCompIdlbl.Text = data.Item1;
                recommendCompNamelbl.Text = data.Item2;

                Competition comp6 = new Competition(recommendCompIdlbl.Text);
                foreach (string comp in comp6.compMemberList())
                {
                    memberListBox.Items.Add(comp);
                }
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            Recommendation send1 = new Recommendation(recommendMembNamelbl.Text, recommendCompIdlbl.Text, detailsTxtBox.Text);
            MessageBox.Show(send1.sendRecommend());
        }

        private void bckBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Coach back = new Coach(name, role);
            back.ShowDialog();
        }
    }
}
