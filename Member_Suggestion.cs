using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Y1S2
{
    public partial class Member_Suggestion : Form
    {
        public string name;
        public Member_Suggestion()
        {
            InitializeComponent();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            string status;
            Suggestions suggestions = new Suggestions();
            status = suggestions.send_suggest(name, suggest_rchtxtbx.Text);
            MessageBox.Show(status);
        }
    }
}
