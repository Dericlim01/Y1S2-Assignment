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
                string selected_data = memberListBox.SelectedItem.ToString();

                Competition details = new Competition();
                var data = details.findmember(selected_data);
                assignMembNamelbl.Text = data.Item1;
                assignMembLevellbl.Text = data.Item2;
                assignMembAgelbl.Text = data.Item3;
                
            }
            
        }

        private void AssignCompetition_Load(object sender, EventArgs e)
        {
            Competition comp4 = new Competition();
            foreach (string user in comp4.memberlist()) 
            {
                memberListBox.Items.Add(user);
            } 
        }
    }
}
