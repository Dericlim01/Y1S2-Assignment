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
    public partial class Member : Form
    {
        // Create a field for name
        public static string name;
        public Member()
        {
            InitializeComponent();
        }

        public Member(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void Member_Load(object sender, EventArgs e)
        {
            lblname.Text = name;
            lbltype.Text = "Member";
        }
    }
}
