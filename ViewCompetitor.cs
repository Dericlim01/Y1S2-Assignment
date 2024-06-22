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
    public partial class ViewCompetitor : Form
    {
        public string name;
        public string role;

        public ViewCompetitor()
        {
            InitializeComponent();
        }

        public ViewCompetitor(string n, string r)
        {
            InitializeComponent();
            name = n;
            role = r;
        }

        private void competitionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (competitionListBox.SelectedIndex != -1)
            {
                compMemberListBox.Items.Clear();
                // Retrieve the selected item from the list box
                string selected_competition = competitionListBox.SelectedItem.ToString();
                Competition details = new Competition();
                var data = details.findCompetition(selected_competition);
                viewCompIdlbl.Text = data.Item1;
                viewComNamelbl.Text = data.Item2;
                viewCompDatelbl.Text = data.Item3;
                viewCompVenuelbl.Text = data.Item4;

                Competition comp6 = new Competition(viewCompIdlbl.Text);
                foreach (string comp in comp6.compMemberList())
                {
                    compMemberListBox.Items.Add(comp);
                }
            }
        }

        private void RecordResult_Load(object sender, EventArgs e)
        {
            Competition comp5 = new Competition();
            foreach (string comp in comp5.compList())
            {
                competitionListBox.Items.Add(comp);
            }
        }

        private void compMemberListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (compMemberListBox.SelectedIndex != -1)
            {
                // Retrieve the selected item from the list box
                string selected_member = compMemberListBox.SelectedItem.ToString();
                Member_c details = new Member_c();
                var data = details.findMember(selected_member, viewCompIdlbl.Text);
                viewCompMemberName.Text =  data.Item1;
                viewCompMemberAge.Text =  data.Item2;
                if (data.Item4 == "")
                {
                    viewCompMemberRank.Text = "Not Available";
                }
                else
                {
                    viewCompMemberRank.Text =  data.Item4;
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
