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
            int length = Convert.ToInt32(txtA7Eingabe.Text) - 1;
            // länge auf eingabe -1 initialisieren, damit die Zahl mit dem schleifenindex übereinstimmt
            if (length > -1) lbxA7Ausgabe.Items.Add("1");
            if (length > 0) lbxA7Ausgabe.Items.Add("1");
            // die ersten 2 Zahlen werden hinzugefügt, da sonst element [-1] der listbox abgefragt würde
            for (int i = 1; i < length; i++)
            {
                lbxA7Ausgabe.Items.Add(
                    Convert.ToString(
                        Convert.ToInt32(lbxA7Ausgabe.Items[i]) + Convert.ToInt32(lbxA7Ausgabe.Items[i - 1])
                        )
                    );
                    // element zu listbox mit Wert listbox[i]+listbox[i-1] hinzufügen
            }
        }

        private void btnA7Zuruecksetzen_Click(object sender, EventArgs e)
        {
            txtA7Eingabe.Clear();
            lbxA7Ausgabe.Items.Clear();
            // alle Felder leeren
        }
    }
}
