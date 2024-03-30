using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Y1S2
{
    public partial class RecordResult : Form
    {
        public RecordResult()
        {
            InitializeComponent();
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
                recordResultIdlbl.Text = data.Item1;
                recordCompNamelbl.Text = data.Item2;


                Competition comp6 = new Competition(recordResultIdlbl.Text);
                foreach (string comp in comp6.compMemberList())
                {
                    compMemberListBox.Items.Add(comp);
                }


            }
        }

        private void compMemberListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (compMemberListBox.SelectedIndex != -1)
            {
                // Retrieve the selected item from the list box
                string selected_member = compMemberListBox.SelectedItem.ToString();
                Member_c details = new Member_c();
                var data = details.findMember(selected_member, recordResultIdlbl.Text);
                recordMemberName.Text = data.Item1;
                if (data.Item4 == "")
                {
                    recordMemberRank.Text = "Not Available";
                }
                else
                {
                    recordMemberRank.Text = data.Item4;
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int ranking;
            if (int.TryParse(recordRankTxt.Text, out ranking))
            {
                // Conversion successful, 'number' contains the integer value
                Competition comp6 = new Competition(recordResultIdlbl.Text, recordMemberName.Text, ranking);
                MessageBox.Show(comp6.recordCompResult());

            }
            else
            {
                // Conversion failed, invalid input
                MessageBox.Show("Invalid input! Please enter a valid integer.");

            }
        }
    }
}
