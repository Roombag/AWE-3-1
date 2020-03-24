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
    public partial class Aufgabe4 : Form
    {
        public Aufgabe4()
        {
            InitializeComponent();
        }

        private void btnA4Start_Click(object sender, EventArgs e)
        {
            lbxA4Ausgabe.Items.Clear();
            int eingabe = Convert.ToInt32(txtA4Eingabe.Text);
            int rest = 0;
            string ergebnis = "";
            //Eingaben in einfachen Variablen speichern, ListBox leeren
            while (eingabe != 0)
            {

                rest = eingabe % 2;
                //modulo division
                lbxA4Ausgabe.Items.Add(
                    Convert.ToString(eingabe) + 
                    " : 2 = " +
                    Convert.ToString(eingabe/2) +
                    " Rest " + 
                    Convert.ToString(rest)
                    );
                //Zusammenstellen der Ausgabe
                ergebnis = Convert.ToString(rest) + ergebnis;
                eingabe /= 2;
                //Ergebnis vor String einfügen, eingabe dividieren

            }
            lbxA4Ausgabe.Items.Add("Ergebnis: " + ergebnis);
            //Ausgabe Endergebnis
        }
    }
}
