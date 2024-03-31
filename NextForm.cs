using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Y1S2
{
    internal class NextForm
    {
        public void Next(Form currentForm, Form nextForm)
        {
            currentForm.Hide();

            nextForm.ShowDialog();

            currentForm.Close();
        }
    }
}
