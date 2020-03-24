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
    public partial class Aufgabe5 : Form
    {
        public Aufgabe5()
        {
            InitializeComponent();
        }

        private void btnA5Start_Click(object sender, EventArgs e)
        {
            lbxA5Ausgabe.Items.Clear();
            // listbox leeren
            double intUnten = 0;
            double intOben = 1;
            // Intervallgrenzen Oben und Unten
            double eingabe = Convert.ToDouble(txtA5Eingabe.Text);
            double q1 = 1, q2 = 1;
            double zwErgebnis = 0;
            // Rechenvariable
            double intSchritt = intOben - intUnten;
            do
            {
                do
                {
                    zwErgebnis = q1 * q1;
                    q2 = q1;
                    q1 += intSchritt;
                } while (zwErgebnis < (eingabe * eingabe));
                intUnten = q1;
                intOben = q2;
                lbxA5Ausgabe.Items.Add(
                    "[" + 
                    Convert.ToString(intUnten) + 
                    ";" +
                    Convert.ToString(intOben) + 
                    "]"
                    );
            } while (zwErgebnis != (eingabe * eingabe));


        }
    }
}
