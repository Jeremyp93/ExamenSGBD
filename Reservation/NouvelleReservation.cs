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
    public partial class NouvelleReservation : Form
    {
        public NouvelleReservation()
        {
            InitializeComponent();
            this.ActiveControl = textBoxPrenom; //On met le focus sur le textboxPrenom
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            int age;
            if (Int32.TryParse(textBoxAge.Text, out age)) //On verifie si l'age entrée est bien un nombre et si oui on converti en int
            {
                if (age >= 18 && textBoxPrenom.Text != "" && textBoxNom.Text != "") // Si l'age entrée est plus grand que 18 et si le prenom et nom ont été introduit alors
                {
                    helper.nom = textBoxNom.Text;
                    helper.prenom = textBoxPrenom.Text;
                    this.Hide();
                    NouvelleReservation1 oNouvelleReservation1 = new NouvelleReservation1(); //On ouvre le form suivant
                    oNouvelleReservation1.Closed += (s, args) => this.Close();
                    oNouvelleReservation1.MdiParent = this.MdiParent;
                    oNouvelleReservation1.Show();
                }
                else
                {
                    MessageBox.Show("Tous les champs sont obligatoires et/ou l'age minimum pour faire une reservation est de 18 ans !");
                    textBoxAge.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vous n'avez pas entré un nombre valide pour l'age");
            }
        }
    }
}
