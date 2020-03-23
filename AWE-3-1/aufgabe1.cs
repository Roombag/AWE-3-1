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
    public partial class Aufgabe1 : Form
    {
        public Aufgabe1()
        {
            InitializeComponent();
        }

        private void btnA1aStart_Click(object sender, EventArgs e)
        {
            lstShow.Items.Clear();
            lstA1Index.Items.Clear();
            for (int i = 10; i >= 0; i--)
            {
                lstShow.Items.Add(Convert.ToString(i));
                lstA1Index.Items.Add(Convert.ToString(i));
            }
        }

        private void btnA1bStart_Click(object sender, EventArgs e)
        {
            lstShow.Items.Clear();
            lstA1Index.Items.Clear();
            for (int i = 5; i < 15; i++)
            {
                double y = Math.Sqrt(i);
                lstShow.Items.Add(Convert.ToString(y));
                lstA1Index.Items.Add(Convert.ToString(i));
            }
        }
    }
}
