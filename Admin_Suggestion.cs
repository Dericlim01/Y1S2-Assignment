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
    public partial class Admin_Suggestion : Form
    {
        public Admin_Suggestion()
        {
            InitializeComponent();
        }

        private void Admin_Suggestion_Load(object sender, EventArgs e)
        {
            Suggestions suggestions = new Suggestions();
            foreach (string data in suggestions.member_search())
            {
                member_listbx.Items.Add(data);
            }
        }

        private void member_listbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (member_listbx.SelectedIndex != -1)
            {
                string selected_data = member_listbx.SelectedItem.ToString();

                Suggestions suggestions = new Suggestions();
                var suggest = suggestions.receive_suggest(selected_data);
                suggest_listbx.Items.Add(suggest);
            }
        }

        private void suggest_listbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (suggest_listbx.SelectedIndex != -1)
            {
                string selected_data = suggest_listbx.SelectedItem.ToString();

                suggestion_lbl.Text = selected_data;
            }
        }
    }
}
