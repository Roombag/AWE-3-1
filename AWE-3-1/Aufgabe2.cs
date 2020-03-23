using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AWE_3_1
{
    public partial class Aufgabe2 : Form
    {
        public Aufgabe2()
        {
            InitializeComponent();
        }

        private void btnA2Start_Click(object sender, EventArgs e)
        {
            int start = Convert.ToInt32(txtA2Startwert.Text);
            int ende = Convert.ToInt32(txtA2Endwert.Text);
            for (int i = start; i < ende; i++)
            {
                lbxA2Ausgabe.Items.Add(i);
            }
        }
    }
}
