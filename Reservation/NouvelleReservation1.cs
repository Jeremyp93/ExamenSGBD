using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helpers;

namespace Reservation
{
    public partial class NouvelleReservation1 : Form
    {
        public NouvelleReservation1()
        {
            InitializeComponent();
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            helper.dateReservation = dateTimePickerReservation.Value.Date; //On enregistre la date dans une variable accessible par les autres forms.
            this.Hide();
            NouvelleReservation2 oNouvelleReservation2 = new NouvelleReservation2(); // On ouvre le prochain form
            oNouvelleReservation2.Closed += (s, args) => this.Close();
            oNouvelleReservation2.MdiParent = this.MdiParent;
            oNouvelleReservation2.Show();
        }
    }
}
