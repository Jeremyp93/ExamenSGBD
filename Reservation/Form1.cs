using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNouvelleReservation_Click(object sender, EventArgs e)
        {
            this.Hide();
            NouvelleReservation oNouvelleReservation = new NouvelleReservation();
            oNouvelleReservation.Closed += (s, args) => this.Close();
            oNouvelleReservation.MdiParent = this.MdiParent;
            oNouvelleReservation.Show();
        }

        private void buttonModifierReservation_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifierReservation oModifierReservation = new ModifierReservation();
            oModifierReservation.Closed += (s, args) => this.Close();
            oModifierReservation.MdiParent = this.MdiParent;
            oModifierReservation.Show();
        }
    }
}
