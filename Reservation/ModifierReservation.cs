using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Helpers;

namespace Reservation
{
    public partial class ModifierReservation : Form
    {
        public ModifierReservation()
        {
            InitializeComponent();
            this.ActiveControl = textBoxNumeroReservation;
        }

        private void buttonContinuer_Click(object sender, EventArgs e)
        {
            try
            {
                helper.numeroReservation = textBoxNumeroReservation.Text;
                if (Manage.GetListReservation().Exists(x => x.numeroReservation == helper.numeroReservation))
                {
                    helper.supprimer = true;
                    helper.numeroReservation = textBoxNumeroReservation.Text;
                    this.Hide();
                    NouvelleReservationCommande oNouvelleReservationCommande = new NouvelleReservationCommande();
                    oNouvelleReservationCommande.Closed += (s, args) => this.Close();
                    oNouvelleReservationCommande.MdiParent = this.MdiParent;
                    oNouvelleReservationCommande.Show();
                }
                else
                {
                    MessageBox.Show("Cette reservation n'existe pas !");
                    this.ActiveControl = textBoxNumeroReservation;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
