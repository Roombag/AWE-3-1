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
            double q1 = 0, q2 = 0;
            double zwErgebnis = 0;
            // Rechenvariable
            double intSchritt = 1;
            do
            {
                do
                {
                    q2 = q1;
                    q1 = Math.Round(intSchritt + q1, 15);
                    zwErgebnis = Math.Round(q1 * q1, 15);
                } while (zwErgebnis < eingabe);
                intUnten = q2;
                intOben = q1;
                q1 = intUnten;
                q2 = intOben;
                lbxA5Ausgabe.Items.Add(
                    "[" + 
                    Convert.ToString(intUnten) + 
                    ";" +
                    Convert.ToString(intOben) + 
                    "]" +
                    "Intevall: " +
                    Convert.ToString(intSchritt)
                    );
                intSchritt = intSchritt / 10;
            } while (zwErgebnis != eingabe);

            lbxA5Ausgabe.Items.Add(
                "Ergebnis: " +
                Convert.ToString(q2)
                );

        }
    }
}
