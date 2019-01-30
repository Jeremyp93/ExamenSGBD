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

namespace Administration
{
    public partial class DetailRestaurant : Form
    {
        private int idRestaurant, idGroupe;
        public DetailRestaurant(int idRestaurant, int idGroupe)
        {
            InitializeComponent();
            this.idRestaurant = idRestaurant;
            this.idGroupe = idGroupe;
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 oForm1 = new Form1();
            oForm1.Closed += (s, args) => this.Close();
            oForm1.MdiParent = this.MdiParent;
            oForm1.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet oDataSet = Manage.GetReservationByRestaurantAndDateAndReservation(dateTimePicker1.Value.Date, idRestaurant, (Int32)((DataRowView)listBox1.SelectedItem)["idReservation"]);
            labelTable.Text = oDataSet.Tables["Reservation"].Rows[0]["nomTable"].ToString();
            labelPlacesDispo.Text = oDataSet.Tables["Reservation"].Rows[0]["nbreDePlaces"].ToString();
            labelPlacesReservees.Text = oDataSet.Tables["Reservation"].Rows[0]["nbreDePersonnes"].ToString();
            labelPrixTotal.Text = oDataSet.Tables["Reservation"].Rows[0]["prixTotal"].ToString();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet oDataSet = Manage.GetReservationByRestaurantAndDate(dateTimePicker1.Value.Date, idRestaurant);
                listBox1.DataSource = oDataSet.Tables["Reservation"];
                listBox1.DisplayMember = "numeroReservation";
                listBox1.ValueMember = "idReservation";
                if (listBox1.Items.Count != 0)
                {
                    DataSet oDataSet1 = Manage.GetReservationByRestaurantAndDateAndReservation(dateTimePicker1.Value.Date, idRestaurant, (Int32)((DataRowView)listBox1.SelectedItem)["idReservation"]);
                    labelTable.Text = oDataSet1.Tables["Reservation"].Rows[0]["nomTable"].ToString();
                    labelPlacesDispo.Text = oDataSet1.Tables["Reservation"].Rows[0]["nbreDePlaces"].ToString();
                    labelPlacesReservees.Text = oDataSet1.Tables["Reservation"].Rows[0]["nbreDePersonnes"].ToString();
                    labelPrixTotal.Text = oDataSet1.Tables["Reservation"].Rows[0]["prixTotal"].ToString();
                    DataTable dataTable = oDataSet.Tables["Reservation"];
                    labelChiffreDaffaire.Text = dataTable.Compute("Sum(prixTotal)", "").ToString();
                    buttonComposition.Enabled = true;
                }
                else
                {
                    labelTable.Text = "n/a";
                    labelPlacesDispo.Text = "n/a";
                    labelPlacesReservees.Text = "n/a";
                    labelPrixTotal.Text = "n/a";
                    labelChiffreDaffaire.Text = "n/a";
                    buttonComposition.Enabled = false;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            
        }

        private void buttonComposition_Click(object sender, EventArgs e)
        {
            CompositionReservation oCompositionReservation = new CompositionReservation((Int32)((DataRowView)listBox1.SelectedItem)["idReservation"], idRestaurant);
            oCompositionReservation.MdiParent = this.MdiParent;
            oCompositionReservation.Show();
        }

        private void DetailRestaurant_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet oDataSet = Manage.GetReservationByRestaurantAndDate(dateTimePicker1.Value.Date, idRestaurant);
                listBox1.DataSource = oDataSet.Tables["Reservation"];
                listBox1.DisplayMember = "numeroReservation";
                listBox1.ValueMember = "idReservation";
                DataTable dataTable = oDataSet.Tables["Reservation"];
                labelChiffreDaffaire.Text = dataTable.Compute("Sum(prixTotal)", "").ToString();
                if (listBox1.Items.Count != 0)
                {
                    DataSet oDataSet1 = Manage.GetReservationByRestaurantAndDateAndReservation(dateTimePicker1.Value.Date, idRestaurant, (Int32)((DataRowView)listBox1.SelectedItem)["idReservation"]);
                    labelTable.Text = oDataSet1.Tables["Reservation"].Rows[0]["nomTable"].ToString();
                    labelPlacesDispo.Text = oDataSet1.Tables["Reservation"].Rows[0]["nbreDePlaces"].ToString();
                    labelPlacesReservees.Text = oDataSet1.Tables["Reservation"].Rows[0]["nbreDePersonnes"].ToString();
                    labelPrixTotal.Text = oDataSet1.Tables["Reservation"].Rows[0]["prixTotal"].ToString();
                    buttonComposition.Enabled = true;
                }
                else
                {
                    labelTable.Text = "n/a";
                    labelPlacesDispo.Text = "n/a";
                    labelPlacesReservees.Text = "n/a";
                    labelPrixTotal.Text = "n/a";
                    labelChiffreDaffaire.Text = "n/a";
                    buttonComposition.Enabled = false;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }


    }
}
