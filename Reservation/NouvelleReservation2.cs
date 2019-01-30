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
    public partial class NouvelleReservation2 : Form
    {
        Random rand = new Random(); // On instancie un objet Random
        public NouvelleReservation2()
        {
            InitializeComponent();
        }

        private void NouvelleReservation2_Load(object sender, EventArgs e)
        {
            try
            {
                listBoxRestaurant.DataSource = Manage.GetAllRestaurant(); //On introduit dans la listbox tous les restaurants
                listBoxRestaurant.DisplayMember = "RESTO"; // On affichie la colonne RESTO du select
                listBoxRestaurant.ValueMember = "idRestaurants"; // On utilise la colonne idRestaurant comme valeur de l'element
                listBoxRestaurant.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void listBoxRestaurant_SelectedIndexChanged(object sender, EventArgs e) //Quand on change de restaurant
        {
            try
            {
                var selectedItem = (AllRestaurantModel)listBoxRestaurant.SelectedItem; //On enregistre l'objet selectionné (ici le resto) dans une variable
                comboBoxTables.DataSource =
                    Manage.GetTablesByRestaurant(selectedItem.idRestaurants, helper.dateReservation); // On ajoute les tables dispo dans la combobox en fonction du resto choisi
                comboBoxTables.DisplayMember = "TABLECHAISE"; // On affiche la colonne TABLECHAISE du select
                comboBoxTables.ValueMember = "idTables"; // On utilise la colonne idTables comme valeur de l'element
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message); // On affiche l'erreur en MessageBox
            }
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            try
            {
                int nombre;
                var selectedItem = (AllRestaurantModel)listBoxRestaurant.SelectedItem; //On enregistre le resto choisi dans une variable
                var selectedTables = (TablesByRestaurantModel)comboBoxTables.SelectedItem; // On enregistre la table choisi dans une variable
                helper.res = "RES"; //Premiere partie du numero de reservation
                bool continuer = true; //On donne la valeur true à continuer qu'on aura besoin pour generer le numero de reservation
                if (textBoxNombreDePersonnes.Text != "" && Int32.TryParse(textBoxNombreDePersonnes.Text, out nombre)) // SI le nombre de personnes n'est pas vide et si c'est bien un nombre
                {
                    if (nombre >= ((Manage.GetNbreChaise(selectedTables.idTables))) / 2 && nombre <= (Manage.GetNbreChaise(selectedTables.idTables))) // Si le nombre est bien plus grand que la moitié des places dispos ou si il n'est plus grand que le max de places
                    {
                        helper.nombrePersonnesReservation = nombre;
                        helper.idRestaurant = selectedItem.idRestaurants;
                        helper.idTables = selectedTables.idTables;
                        var lstRes = Manage.GetListReservation(); // On popule la liste lstRES avec toute les resrvation
                        while (continuer) // tant que continuer = true
                        {
                            helper.num = rand.Next(1, 1000); //On genere un nombre entre 1 et 1000 aleatoirement
                            helper.numeroReservation = helper.res + helper.num.ToString("D4"); // On crée le numero de reservation en ajoutant RES et le nombre aleatoire à 4 chiffres
                            if (!lstRes.Exists(x => x.numeroReservation == helper.numeroReservation)) // Si le numero de reservation n'existe pas encorealors on quitte la boulce. sinon on recommence
                                continuer = false;
                        }
                        // On ajoute la reservation dans la DB
                        Manage.AjouterReservation(helper.numeroReservation, selectedTables.idTables, helper.dateReservation, helper.prenom, helper.nom, nombre);
                        MessageBox.Show("Nous vous avons attribué le numéro de réservation : " + helper.numeroReservation +
                                        ". Veuillez bien le conserver afin de pouvoir modifier votre reservation si necessaire. ");
                        MessageBox.Show("Veuillez maintenant ajouter les participants et indiquer vos choix afin de finaliser votre commande !");
                        this.Hide();
                        NouvelleReservationCommande oNouvelleReservationCommande = new NouvelleReservationCommande(); // On passe a la suite
                        oNouvelleReservationCommande.Closed += (s, args) => this.Close();
                        oNouvelleReservationCommande.MdiParent = this.MdiParent;
                        oNouvelleReservationCommande.Show();
                    }
                    else
                    {
                        MessageBox.Show("Vous n'etes pas assez ou vous êtes trop que pour reserver la table choisie !");
                    }
                }
                else
                {
                    MessageBox.Show("Vous n'avez pas introduit un nombre de personnes valides !");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("L'ajout n'a pas reussi.. Veuillez vérifier que vous ayez bien selectionné une table valide !");
            }
        }
    }
}
