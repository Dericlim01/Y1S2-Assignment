using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Y1S2
{
    public partial class Edit_Competition : Form
    {
        public Edit_Competition()
        {
            InitializeComponent();
        }


        public Edit_Competition(string compId, string compName, string compDate, string dueDate,string venue, string details)
        {
            InitializeComponent();
            editCompIdLbl.Text = compId;
            editCompNameTB.Text = compName;
            DateTime dateTime = DateTime.ParseExact(compDate, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture); 
            DateTime dateTime2 = DateTime.ParseExact(dueDate, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
            editCompDate1.Value = dateTime;
            editDueDate.Value = dateTime2;
            editCompVenueTB.Text = venue;
            editCompDetailTB.Text = details;
        }
        private void Edit_Competition_Load(object sender, EventArgs e)
        {
        }

        private void editCompbtn_Click(object sender, EventArgs e)
        {
            string formattedCompDate = editCompDate1.Value.ToString("yyyy-MM-dd");
            string formattedDueDate = editDueDate.Value.ToString("yyyy-MM-dd");
            Competition comp2 = new Competition(editCompIdLbl.Text,editCompNameTB.Text, formattedCompDate, formattedDueDate, editCompVenueTB.Text, editCompDetailTB.Text);
            MessageBox.Show(comp2.editCompetition());

        }
    }
}