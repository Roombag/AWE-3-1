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
            double eingabe = Convert.ToDouble(txtA6Eingabe.Text);
            // Eingabe in einfacher Variable speichern
            double ergebnis = 0;
            double summe = 0;

            lbxA6Ausgabe.Items.Add(eingabe);
            // eingabe zur listbox hinzufügen
            txtA6Eingabe.Clear();

            int laenge = lbxA6Ausgabe.Items.Count;
            // Anzahl der listbox elemente als int speichern

            for (int i = 0; i < laenge; i++)
            {
                summe += Convert.ToDouble(lbxA6Ausgabe.Items[i]);
                // i-tes element der listbox zur summe addieren
            }
            ergebnis = summe / laenge;
            // durchschnitt berechnen
            txtA6Durchschnitt.Text = Convert.ToString(ergebnis);
            // ergebnis in textbox schreiben
        }

        private void btnA6Zurueck_Click(object sender, EventArgs e)
        {
            lbxA6Ausgabe.Items.Clear();
            txtA6Eingabe.Clear();
            txtA6Durchschnitt.Clear();
            // alle Felder leeren
        }
    }
}
