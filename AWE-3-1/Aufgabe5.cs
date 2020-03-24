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
            // aktuelle quadrierte Zahl und zuletzt quadrierte Zahl
            double zwErgebnis = 0;
            // Rechenvariable
            double intSchritt = 1;
            // schrittgröße des aktuellen Intervalls
            do
            {
                do
                {
                    q2 = q1;
                    q1 = Math.Round(intSchritt + q1, 15);
                    zwErgebnis = Math.Round(q1 * q1, 15);
                    // schleift durch alle zahlen im intervall mit dem aktuellen intervallschritt
                } while (zwErgebnis < eingabe);
                // solange bis eine größere Zahl als die eingegebene gefunden wird
                intUnten = q2;
                intOben = q1;
                // interval neu setzen (haupsächlich zur Übersicht und zum Debuggen)
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
                // Ausgabe in ListBox
                intSchritt = intSchritt / 10;
                // Schrittgröße für nächsten Schleifendurchlauf ändern
            } while (zwErgebnis != eingabe);
            // solange bis der richtige Wert gefunden wurde
            lbxA5Ausgabe.Items.Add(
                "Ergebnis: " +
                Convert.ToString(q2)
                );
            // Ausgabe in ListBox
        }
    }
}
