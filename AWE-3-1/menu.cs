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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btnMenuA1_Click(object sender, EventArgs e)
        {
            Aufgabe1 aufgabe1 = new Aufgabe1();
            aufgabe1.Show();
        }

        private void btnMenuA2_Click(object sender, EventArgs e)
        {
            Aufgabe2 aufgabe2 = new Aufgabe2();
            aufgabe2.Show();
        }

        private void btnMenuA3_Click(object sender, EventArgs e)
        {
            Aufgabe3 aufgabe3 = new Aufgabe3();
            aufgabe3.Show();
        }

        private void btnMenuA4_Click(object sender, EventArgs e)
        {
            Aufgabe4 aufgabe4 = new Aufgabe4();
            aufgabe4.Show();
        }

        private void btnMenuA5_Click(object sender, EventArgs e)
        {
            Aufgabe5 aufgabe5 = new Aufgabe5();
            aufgabe5.Show();
        }
    }
}
