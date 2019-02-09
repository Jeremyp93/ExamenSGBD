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
    public partial class NouvelleReservationAjouterParticipants : Form
    {
        public NouvelleReservationAjouterParticipants()
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

        private void NouvelleReservationAjouterParticipants_Load(object sender, EventArgs e)
        {
            try
            {
                if (Manage.GetMenus().Where(x => x.idRestaurant == GetNumeroRestaurant()).ToList().Count == 0)
                    buttonMenu.Enabled = false;
                if (helper.modifier || helper.prenom != "") // Si on a appuyé sur modifier on recupère le nom de la reservation
                    textBoxPrenom.Text = helper.prenomParticipant;
                comboBoxEntree.DataSource = Manage.GetCarteByRestaurantAndType(GetNumeroRestaurant(), 1); // Recuperer les entrees du restaurant
                comboBoxEntree.DisplayMember = "Element";
                comboBoxEntree.ValueMember = "idCarteRestaurant";
                if (helper.modifier) // Si on a appuyé sur modifier on selectionne le plat choisi
                {
                    int selectEntree = Manage.GetDetailReservation().FirstOrDefault(x =>
                        x.idDetailReservation == helper.idDetail).entree;
                    comboBoxEntree.SelectedValue = selectEntree; // On selectionne le plat choisi
                }

                comboBoxPlat.DataSource = Manage.GetCarteByRestaurantAndType(GetNumeroRestaurant(), 2); // Recuperer les plats du restaurant
                comboBoxPlat.DisplayMember = "Element";
                comboBoxPlat.ValueMember = "idCarteRestaurant";
                if (helper.modifier) // Si on a appuyé sur modifier on selectionne le plat choisi
                {
                    int selectPlat = Manage.GetDetailReservation().FirstOrDefault(x =>
                        x.idDetailReservation == helper.idDetail).plat;
                    comboBoxPlat.SelectedValue = selectPlat; // On selectionne le plat choisi
                }

                comboBoxDessert.DataSource = Manage.GetCarteByRestaurantAndType(GetNumeroRestaurant(), 3); // Recuperer les desserts du restaurant
                comboBoxDessert.DisplayMember = "Element";
                comboBoxDessert.ValueMember = "idCarteRestaurant";
                if (helper.modifier) // Si on a appuyé sur modifier on selectionne le plat choisi
                {
                    int selectDessert = Manage.GetDetailReservation().FirstOrDefault(x =>
                        x.idDetailReservation == helper.idDetail).dessert;
                    comboBoxDessert.SelectedValue = selectDessert; // On selectionne le plat choisi
                }

                var selectedEntree = (CarteByRestaurantAndTypeModel)comboBoxEntree.SelectedItem;
                var selectedPlat = (CarteByRestaurantAndTypeModel)comboBoxPlat.SelectedItem;
                var selectedDessert = (CarteByRestaurantAndTypeModel)comboBoxDessert.SelectedItem;
                labelPrixEntree.Text = Manage.GetCarteRestaurant()
                    .FirstOrDefault(x => x.idCarteRestaurant == selectedEntree.idCarteRestaurant).Prix.ToString();
                labelPrixPlat.Text = Manage.GetCarteRestaurant()
                    .FirstOrDefault(x => x.idCarteRestaurant == selectedPlat.idCarteRestaurant).Prix.ToString();
                labelPrixDessert.Text = Manage.GetCarteRestaurant()
                    .FirstOrDefault(x => x.idCarteRestaurant == selectedDessert.idCarteRestaurant).Prix.ToString();
                helper.prixParPersonnes = Int32.Parse(labelPrixEntree.Text) + Int32.Parse(labelPrixPlat.Text) + Int32.Parse(labelPrixDessert.Text);
                labelPrixTotal.Text = helper.prixParPersonnes.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void comboBoxEntree_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedEntree = (CarteByRestaurantAndTypeModel)comboBoxEntree.SelectedItem;
                labelPrixEntree.Text = Manage.GetCarteRestaurant()
                    .FirstOrDefault(x => x.idCarteRestaurant == selectedEntree.idCarteRestaurant).Prix.ToString();
                helper.prixParPersonnes = Int32.Parse(labelPrixEntree.Text) + Int32.Parse(labelPrixPlat.Text) + Int32.Parse(labelPrixDessert.Text);
                labelPrixTotal.Text = helper.prixParPersonnes.ToString();
            }
            catch (Exception)
            {
                labelPrixEntree.Text = "Not found";
            }
        }

        private void comboBoxPlat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedPlat = (CarteByRestaurantAndTypeModel)comboBoxPlat.SelectedItem;
                labelPrixPlat.Text = Manage.GetCarteRestaurant()
                    .FirstOrDefault(x => x.idCarteRestaurant == selectedPlat.idCarteRestaurant).Prix.ToString();
                helper.prixParPersonnes = Int32.Parse(labelPrixEntree.Text) + Int32.Parse(labelPrixPlat.Text) + Int32.Parse(labelPrixDessert.Text);
                labelPrixTotal.Text = helper.prixParPersonnes.ToString();
            }
            catch (Exception)
            {
                labelPrixPlat.Text = "Not found";
            }
        }

        private void comboBoxDessert_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedDessert = (CarteByRestaurantAndTypeModel)comboBoxDessert.SelectedItem;
                labelPrixDessert.Text = Manage.GetCarteRestaurant()
                    .FirstOrDefault(x => x.idCarteRestaurant == selectedDessert.idCarteRestaurant).Prix.ToString();
                helper.prixParPersonnes = Int32.Parse(labelPrixEntree.Text) + Int32.Parse(labelPrixPlat.Text) + Int32.Parse(labelPrixDessert.Text);
                labelPrixTotal.Text = helper.prixParPersonnes.ToString();
            }
            catch (Exception)
            {
                labelPrixEntree.Text = "Not found";
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (textBoxPrenom.Text != "")
            {
                var selectedEntree = (CarteByRestaurantAndTypeModel)comboBoxEntree.SelectedItem;
                var selectedPlat = (CarteByRestaurantAndTypeModel)comboBoxPlat.SelectedItem;
                var selectedDessert = (CarteByRestaurantAndTypeModel)comboBoxDessert.SelectedItem;
                try
                {
                    string nomTemp = helper.prenomParticipant;
                    helper.prenomParticipant = textBoxPrenom.Text;
                    helper.idEntree = selectedEntree.idCarteRestaurant;
                    helper.idPlat = selectedPlat.idCarteRestaurant;
                    helper.idDessert = selectedDessert.idCarteRestaurant;
                    helper.prixParPersonnes = Int32.Parse(labelPrixTotal.Text);
                    if (!Manage.GetDetailReservation().Exists(x => x.idDetailReservation == helper.idDetail))
                    {
                        Manage.AjouteDetailReservation(
                            Manage.GetListReservation()
                                .FirstOrDefault(x => x.numeroReservation == helper.numeroReservation).idReservation,
                            helper.prenomParticipant, helper.idEntree, helper.idPlat, helper.idDessert,
                            helper.prixParPersonnes);
                    }
                    else
                    {
                        int idRes = GetIdReservation();
                        Manage.ModifierDetailReservation(helper.idDetail
                            , textBoxPrenom.Text, helper.idEntree, helper.idPlat, helper.idDessert, helper.prixParPersonnes);
                    }
                    this.Hide();
                    NouvelleReservationCommande oNouvelleReservationCommande = new NouvelleReservationCommande();
                    oNouvelleReservationCommande.Closed += (s, args) => this.Close();
                    oNouvelleReservationCommande.MdiParent = this.MdiParent;
                    oNouvelleReservationCommande.Show();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Veuillez introduire un prenom !");
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            helper.modifier = false;
            helper.prenom = textBoxPrenom.Text;
            this.Hide();
            NouvelleReservationAjouterParticipantsMenu oNouvelleReservationAjouterParticipantsMenu = new NouvelleReservationAjouterParticipantsMenu(); //On va vers le form ou on peut changer kes choix
            oNouvelleReservationAjouterParticipantsMenu.Closed += (s, args) => this.Close();
            oNouvelleReservationAjouterParticipantsMenu.MdiParent = this.MdiParent;
            oNouvelleReservationAjouterParticipantsMenu.Show();
        }
    }
}
