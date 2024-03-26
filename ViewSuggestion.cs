using System;
using System.Collections;
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
    public partial class ViewSuggestion : Form
    {
        public ViewSuggestion()
        {
            InitializeComponent();
        }

        private void ViewSuggestion_Load(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            list = Suggestion.viewAll();
            foreach (ListViewItem item in list)
            {
                suggestion_lxBox.Items.Add(item);
            }
        }
    }
}
