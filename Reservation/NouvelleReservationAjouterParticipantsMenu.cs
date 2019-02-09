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
    public partial class NouvelleReservationAjouterParticipantsMenu : Form
    {
        public NouvelleReservationAjouterParticipantsMenu()
        {
            InitializeComponent();
        }

        internal int GetNumeroRestaurant() // On recupère le numero du restaurant qui correspond à la reservation
        {
            var idTable = Manage.GetListReservation().FirstOrDefault(x => x.numeroReservation == helper.numeroReservation).idTable;
            return Manage.GetTables().FirstOrDefault(x => x.idTables == idTable).idRestaurant;
        }

        internal int GetIdReservation() // On recupere le numero de la reservation
        {
            return Manage.GetListReservation().FirstOrDefault(x => x.numeroReservation == helper.numeroReservation).idReservation;
        }

        private void NouvelleReservationAjouterParticipantsMenu_Load(object sender, EventArgs e)
        {
            try
            {
                if (helper.modifier || helper.prenom != "")
                    textBoxPrenom.Text = helper.prenomParticipant;
                comboBoxMenu.DataSource = Manage.GetMenus().Where(x => x.idRestaurant == GetNumeroRestaurant()).ToList(); // Recuperer les menus du restaurant
                comboBoxMenu.DisplayMember = "idMenu";
                comboBoxMenu.ValueMember = "idMenu";
                if (helper.modifier) // Si on a appuyé sur modifier on recupère le nom de la reservation
                {
                    int? selectMenu = Manage.GetDetailReservation().FirstOrDefault(x =>
                            x.idDetailReservation == helper.idDetail).idMenu;
                    comboBoxMenu.SelectedValue = selectMenu; // On selectionne le menu choisi
                }

                var selectedMenu = (MenuModel)comboBoxMenu.SelectedItem;

                comboBoxEntree.DataSource = Manage.GetCarteMenu(selectedMenu.idMenu, 1); // Recuperer les entrees du menu
                comboBoxEntree.DisplayMember = "Element";
                comboBoxEntree.ValueMember = "idCarteRestaurant";
                if (helper.modifier) // Si on a appuyé sur modifier on selectionne l'entree choisi
                {
                    int selectEntree = Manage.GetDetailReservation().FirstOrDefault(x =>
                        x.idDetailReservation == helper.idDetail).entree;
                    comboBoxEntree.SelectedValue = selectEntree; // On selectionne l'entree choisi
                }

                comboBoxPlat.DataSource = Manage.GetCarteMenu(selectedMenu.idMenu, 2); // Recuperer les plats du menu
                comboBoxPlat.DisplayMember = "Element";
                comboBoxPlat.ValueMember = "idCarteRestaurant";
                if (helper.modifier) // Si on a appuyé sur modifier on selectionne le plat choisi
                {
                    int selectPlat = Manage.GetDetailReservation().FirstOrDefault(x =>
                        x.idDetailReservation == helper.idDetail).plat;
                    comboBoxPlat.SelectedValue = selectPlat; // On selectionne le plat choisi
                }

                comboBoxDessert.DataSource = Manage.GetCarteMenu(selectedMenu.idMenu, 3); // Recuperer les desserts du menu
                comboBoxDessert.DisplayMember = "Element";
                comboBoxDessert.ValueMember = "idCarteRestaurant";
                if (helper.modifier) // Si on a appuyé sur modifier on selectionne le dessert choisi
                {
                    int selectDessert = Manage.GetDetailReservation().FirstOrDefault(x =>
                        x.idDetailReservation == helper.idDetail).dessert;
                    comboBoxDessert.SelectedValue = selectDessert; // On selectionne le dessert choisi
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            
        }

        private void buttonALaCarte_Click(object sender, EventArgs e)
        {
            try
            {
                helper.modifier = false;
                if (textBoxPrenom.Text != "")
                    helper.prenom = textBoxPrenom.Text;
                this.Hide();
                NouvelleReservationAjouterParticipants oNouvelleReservationAjouterParticipants = new NouvelleReservationAjouterParticipants(); //On va vers le form ou on peut changer kes choix
                oNouvelleReservationAjouterParticipants.Closed += (s, args) => this.Close();
                oNouvelleReservationAjouterParticipants.MdiParent = this.MdiParent;
                oNouvelleReservationAjouterParticipants.Show();
            }
            catch (Exception exception)
            {
                throw exception;
            }
            
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (textBoxPrenom.Text != "")
            {
                var selectedEntree = (CarteMenuModel)comboBoxEntree.SelectedItem;
                var selectedPlat = (CarteMenuModel)comboBoxPlat.SelectedItem;
                var selectedDessert = (CarteMenuModel)comboBoxDessert.SelectedItem;
                var selectedMenu = (MenuModel) comboBoxMenu.SelectedItem;
                helper.idEntree = selectedEntree.idCarteRestaurant;
                helper.idPlat = selectedPlat.idCarteRestaurant;
                helper.idDessert = selectedDessert.idCarteRestaurant;
                helper.prixParPersonnes = Convert.ToInt32((Manage.GetPrixGroupe(selectedEntree.idCarteRestaurant) + Manage.GetPrixGroupe(selectedPlat.idCarteRestaurant) + Manage.GetPrixGroupe(selectedDessert.idCarteRestaurant))*0.9);
                if (Manage.GetDetailReservation().Exists(x => x.idDetailReservation == helper.idDetail))
                {
                    Manage.ModifierDetailReservationMenu(helper.idDetail, textBoxPrenom.Text, helper.idEntree, helper.idPlat, helper.idDessert, helper.prixParPersonnes, selectedMenu.idMenu);
                }
                else
                {
                    Manage.AjouteDetailReservationMenu(GetIdReservation(), textBoxPrenom.Text, helper.idEntree, helper.idPlat, helper.idDessert, helper.prixParPersonnes, selectedMenu.idMenu);
                }
                this.Hide();
                NouvelleReservationCommande oNouvelleReservationCommande = new NouvelleReservationCommande();
                oNouvelleReservationCommande.Closed += (s, args) => this.Close();
                oNouvelleReservationCommande.MdiParent = this.MdiParent;
                oNouvelleReservationCommande.Show();
            }
            else
            {
                MessageBox.Show("Veuillez introduire un prénom !");
            }
        }

        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedMenu = (MenuModel)comboBoxMenu.SelectedItem;

                comboBoxEntree.DataSource = Manage.GetCarteMenu(selectedMenu.idMenu, 1); // Recuperer les entrees du menu
                comboBoxEntree.DisplayMember = "Element";
                comboBoxEntree.ValueMember = "idCarteRestaurant";

                comboBoxPlat.DataSource = Manage.GetCarteMenu(selectedMenu.idMenu, 2); // Recuperer les plats du menu
                comboBoxPlat.DisplayMember = "Element";
                comboBoxPlat.ValueMember = "idCarteRestaurant";

                comboBoxDessert.DataSource = Manage.GetCarteMenu(selectedMenu.idMenu, 3); // Recuperer les desserts du menu
                comboBoxDessert.DisplayMember = "Element";
                comboBoxDessert.ValueMember = "idCarteRestaurant";

                if (Manage.GetCarteMenu(selectedMenu.idMenu, 1).Count == 0 ||
                    Manage.GetCarteMenu(selectedMenu.idMenu, 2).Count == 0 ||
                    Manage.GetCarteMenu(selectedMenu.idMenu, 3).Count == 0)
                    buttonAjouter.Enabled = false;
                else
                {
                    buttonAjouter.Enabled = true;
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
