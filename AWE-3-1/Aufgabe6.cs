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
    public partial class Aufgabe6 : Form
    {
        public Aufgabe6()
        {
            InitializeComponent();
        }

        private void btnA6Naechste_Click(object sender, EventArgs e)
        {
            double eingabe = Convert.ToDouble(txtA6Eingabe);
            double ergebnis = 0;
            double summe = 0;
            int laenge = lbxA6Ausgabe.Items.Count;

        }

        private void btnA6Zurueck_Click(object sender, EventArgs e)
        {
            lbxA6Ausgabe.Items.Clear();
        }
    }
}
