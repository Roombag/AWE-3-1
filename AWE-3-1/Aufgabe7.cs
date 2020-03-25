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
    public partial class Aufgabe7 : Form
    {
        public Aufgabe7()
        {
            InitializeComponent();
        }

        private void btnA7Start_Click(object sender, EventArgs e)
        {

        }

        private void btnA7Zuruecksetzen_Click(object sender, EventArgs e)
        {
            txtA7Eingabe.Clear();
            lbxA7Ausgabe.Items.Clear();
        }
    }
}
