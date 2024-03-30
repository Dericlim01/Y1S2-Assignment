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
    public partial class AssignCompetition : Form
    {
        public AssignCompetition()
        {
            InitializeComponent();
        }

        private void memberListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (memberListBox.SelectedIndex != -1)
            {
                // Retrieve the selected item from the list box
                string selected_member = memberListBox.SelectedItem.ToString();
                Member_c details = new Member_c();
                var data = details.findMember(selected_member, assignCompIdlbl.Text);
                assignMembNamelbl.Text = data.Item1;
                assignMembLevellbl.Text =  data.Item2;
                assignMembAgelbl.Text =  data.Item3;
            }
        }

        private void AssignCompetition_Load(object sender, EventArgs e)
        {
            Member_c memb4 = new Member_c();
            Competition comp4 = new Competition();
            foreach (string member in memb4.memberlist())
            {
                memberListBox.Items.Add(member);
            }
            foreach (string comp in comp4.compList())
            {
                competitionListBox.Items.Add(comp);
            }
        }

        private void competitionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (competitionListBox.SelectedIndex != -1)
            {
                // Retrieve the selected item from the list box
                string selected_competition = competitionListBox.SelectedItem.ToString();
                Competition details = new Competition();
                var data = details.findCompetition(selected_competition);
                assignCompIdlbl.Text = data.Item1;
                assignCompNamelbl.Text =  data.Item2;
                assignCompDatelbl.Text =  data.Item3;
                assignCompVenuelbl.Text = data.Item4;
            }
        }

        private void assignMemberbtn_Click(object sender, EventArgs e)
        {
            Competition comp5 = new Competition(assignCompIdlbl.Text, assignMembNamelbl.Text);
            MessageBox.Show(comp5.assign_member());
        }
    }
}