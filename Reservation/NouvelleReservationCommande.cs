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
    public partial class NouvelleReservationCommande : Form
    {
        public NouvelleReservationCommande()
        {
            InitializeComponent();
        }

        internal int GetNumeroRestaurant() // On crée une fonction qui recupere l'idRestaurant de la reservation
        {
            var idTable = Manage.GetListReservation().FirstOrDefault(x => x.numeroReservation == helper.numeroReservation).idTable;
            return Manage.GetTables().FirstOrDefault(x => x.idTables == idTable).idRestaurant;
        }

        internal int GetNbreParticipant() // On crée une fonction qui recupère le nombre de participant dans la reservation
        {
            return Manage.GetListReservation().FirstOrDefault(x => x.numeroReservation == helper.numeroReservation).nbreDePersonnes;
        }

        internal string GetPrenom() // On crée une fonction qui recupère le prenom de la reservation
        {
            var selectParticipant = (ParticipantParReservationModel)listBoxPersonnesPresentes.SelectedItem;
            return selectParticipant.prenom;
        }

        private void NouvelleReservationCommande_Load(object sender, EventArgs e)
        {
            
            helper.modifier = false; // le form sera aussi utiliser si on veut modifier la reservation mais on part du principe que de base ce n'est pas le cas.
            try
            { // On ajoute les participant de la reservation dans la listbox.
                listBoxPersonnesPresentes.DataSource = Manage.GetParticipantParReservation(Manage.GetListReservation().FirstOrDefault(x => x.numeroReservation == helper.numeroReservation).idReservation);
                listBoxPersonnesPresentes.DisplayMember = "prenom";
                listBoxPersonnesPresentes.ValueMember = "idDetailReservation";
                if (listBoxPersonnesPresentes.Items.Count != 0) // A la base elle sera vide, mais si elle n'est pas vide on indique les choix
                {
                    var selectedParticipant = (ParticipantParReservationModel)listBoxPersonnesPresentes.SelectedItem;
                    labelEntree.Text = Manage.GetCarteByRestaurantAndType(GetNumeroRestaurant(), 1)
                        .FirstOrDefault(x => x.idCarteRestaurant == selectedParticipant.entree).Element;
                    labelPlat.Text = Manage.GetCarteByRestaurantAndType(GetNumeroRestaurant(), 2)
                        .FirstOrDefault(x => x.idCarteRestaurant == selectedParticipant.plat).Element;
                    labelDessert.Text = Manage.GetCarteByRestaurantAndType(GetNumeroRestaurant(), 3)
                        .FirstOrDefault(x => x.idCarteRestaurant == selectedParticipant.dessert).Element;
                    labelPrixTotal.Text = selectedParticipant.prixParPersonne.ToString();
                }

                if (helper.supprimer) // Si on modifie la reservation alors on le bouton supprimer devient visible
                {
                    button_supprimer.Visible = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonAjouterParticipants_Click(object sender, EventArgs e)
        {
            helper.nombrePersonnesReservation = GetNbreParticipant();
            if (listBoxPersonnesPresentes.Items.Count < helper.nombrePersonnesReservation) //Si le max de participant n'est pas encore atteint on passe au form d'ajout de participant
            {
                this.Hide();
                NouvelleReservationAjouterParticipants oNouvelleReservationAjouterParticipants = new NouvelleReservationAjouterParticipants();
                oNouvelleReservationAjouterParticipants.Closed += (s, args) => this.Close();
                oNouvelleReservationAjouterParticipants.MdiParent = this.MdiParent;
                oNouvelleReservationAjouterParticipants.Show();
            }
            else
            {
                MessageBox.Show("Vous ne pouvez plus ajouter de particpants !");
            }
        }

        private void listBoxPersonnesPresentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { // Quand on choisi un autre participant on rafraichi les choix
                var selectedParticipant = (ParticipantParReservationModel)listBoxPersonnesPresentes.SelectedItem;
                labelEntree.Text = Manage.GetCarteByRestaurantAndType(GetNumeroRestaurant(), 1)
                    .FirstOrDefault(x => x.idCarteRestaurant == selectedParticipant.entree).Element;
                labelPlat.Text = Manage.GetCarteByRestaurantAndType(GetNumeroRestaurant(), 2)
                    .FirstOrDefault(x => x.idCarteRestaurant == selectedParticipant.plat).Element;
                labelDessert.Text = Manage.GetCarteByRestaurantAndType(GetNumeroRestaurant(), 3)
                    .FirstOrDefault(x => x.idCarteRestaurant == selectedParticipant.dessert).Element;
                labelPrixTotal.Text = selectedParticipant.prixParPersonne.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonTerminer_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxPersonnesPresentes.Items.Count != GetNbreParticipant()) // Si pas tous les participant ont été ajoutés
                {
                    MessageBox.Show(
                        "N'oubliez pas de completer le menu des participants avant de venir. Si les menus ne sont pas completés votre réservation ne sera pas prise en compte !");
                    this.Hide();
                    Form1 oNouvelleReservation = new Form1();
                    oNouvelleReservation.Closed += (s, args) => this.Close(); // On repasse au form initiale
                    oNouvelleReservation.MdiParent = this.MdiParent;
                    oNouvelleReservation.Show();
                }
                else
                {
                    Manage.ConfirmerReservation(Manage.GetListReservation() // On confirme la reservation dans la db et on rajoute le prix total de la reservation
                        .FirstOrDefault(x => x.numeroReservation == helper.numeroReservation).idReservation, Manage.SumPrixTotalReservation(Manage.GetListReservation()
                        .FirstOrDefault(x => x.numeroReservation == helper.numeroReservation).idReservation));
                    this.Hide();
                    Form1 oNouvelleReservation = new Form1(); // On retourne a la forme initiale
                    oNouvelleReservation.Closed += (s, args) => this.Close();
                    oNouvelleReservation.MdiParent = this.MdiParent;
                    oNouvelleReservation.Show();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            helper.modifier = true; //On eut modifier un participant
            var selectedDetailReservation = (ParticipantParReservationModel)listBoxPersonnesPresentes.SelectedItem;
            helper.idDetail = selectedDetailReservation.idDetailReservation; // On enregistre l'idDetail de la personne selectionnée
            helper.prenomParticipant = GetPrenom();
            if (Manage.GetIdMenu(helper.idDetail) == null)
            {
                this.Hide();
                NouvelleReservationAjouterParticipants oNouvelleReservationAjouterParticipants = new NouvelleReservationAjouterParticipants(); //On va vers le form ou on peut changer kes choix
                oNouvelleReservationAjouterParticipants.Closed += (s, args) => this.Close();
                oNouvelleReservationAjouterParticipants.MdiParent = this.MdiParent;
                oNouvelleReservationAjouterParticipants.Show();
            }
            else
            {
                this.Hide();
                NouvelleReservationAjouterParticipantsMenu oNouvelleReservationAjouterParticipantsMenu = new NouvelleReservationAjouterParticipantsMenu(); //On va vers le form ou on peut changer kes choix
                oNouvelleReservationAjouterParticipantsMenu.Closed += (s, args) => this.Close();
                oNouvelleReservationAjouterParticipantsMenu.MdiParent = this.MdiParent;
                oNouvelleReservationAjouterParticipantsMenu.Show();
            }

        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                int idRes = Manage.GetListReservation().FirstOrDefault(x => x.numeroReservation == helper.numeroReservation).idReservation; //On recupere l'id de la reservation
                Manage.DeleteReservation(idRes); // On supprime la reservation (il y a un trigger qui supprime la reservation et les details lié à la reservation
                MessageBox.Show("Votre reservation a bien été supprimée !");
                this.Hide();
                Form1 oNouvelleReservation = new Form1(); // On retourne vers le form de base
                oNouvelleReservation.Closed += (s, args) => this.Close();
                oNouvelleReservation.MdiParent = this.MdiParent;
                oNouvelleReservation.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
