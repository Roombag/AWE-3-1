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
    public partial class Aufgabe3 : Form
    {
        public Aufgabe3()
        {
            InitializeComponent();
        }

        private void btnA3Start_Click(object sender, EventArgs e)
        {
            lbxA3Ausgabe.Items.Clear();
            int start = Convert.ToInt32(txtA3Startwert.Text);
            int ende = Convert.ToInt32(txtA3Endwert.Text);
            int ergebnis = 0;

            for (int i = start; i <= ende; i++)
            {
                ergebnis = i*i;
                lbxA3Ausgabe.Items.Add(ergebnis);
            }
        }
    }
}
