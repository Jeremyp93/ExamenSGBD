using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Administration;
using Reservation;

namespace MainForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void administrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administration.Form1 o = new Administration.Form1();

            o.MdiParent = this;
            o.Show();
        }

        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservation.Form1 o = new Reservation.Form1();

            o.MdiParent = this;
            o.Show();
        }
    }
}
