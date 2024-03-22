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
    public partial class Admin : Form
    {
        public static string name;
        public Admin()
        {
            InitializeComponent();
        }

        public Admin(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
