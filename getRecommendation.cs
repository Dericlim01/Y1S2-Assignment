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
    public partial class getRecommendation : Form
    {
        public string name;
        public string role;

        public getRecommendation()
        {
            InitializeComponent();
        }

        public getRecommendation(string n, string r)
        {
            InitializeComponent();
            name = n;
            role = r;
        }

        private void getRecommendation_Load(object sender, EventArgs e)
        {
            Competition comp7 = new Competition();
            foreach (string comp in comp7.compList())
            {
                competitionListBox.Items.Add(comp);
            }
        }

        private void memberListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (memberListBox.SelectedIndex != -1)
            {
                // Retrieve the selected item from the list box
                string selected_member = memberListBox.SelectedItem.ToString();
                Member_c information = new Member_c();
                var data = information.findMember(selected_member, recommendCompIdlbl.Text);
                recommendMembNamelbl.Text = data.Item1;
                recommendMembLevellbl.Text = data.Item2;
                Recommendation details = new Recommendation(recommendMembNamelbl.Text, recommendCompIdlbl.Text);
                detailTxtBox.Text = details.getRecommendation();
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

                Recommendation recom2 = new Recommendation(recommendCompIdlbl.Text);
                foreach (string recompMember in recom2.recommendMemberList())
                {
                    memberListBox.Items.Add(recompMember);
                }
            }
        }

        private void bckBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager back = new Manager(name, role);
            back.ShowDialog();
        }
    }
}
