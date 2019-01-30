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
    public partial class DetailGroupe : Form
    {
        private int idGroupe;
        public DetailGroupe(int idGroupe)
        {
            InitializeComponent();
            this.idGroupe = idGroupe;
        }

        private void DetailGroupe_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet oDataSet = Manage.SelectRestaurantsFromGroupe(idGroupe);
                listBoxRestaurant.DataSource = oDataSet.Tables["Restaurants"];
                listBoxRestaurant.DisplayMember = "Resto";
                listBoxRestaurant.ValueMember = "idRestaurants";
                DataSet oDataSet1 = Manage.GetReservationByRestaurantAndDate(dateTimePicker1.Value.Date, (Int32)((DataRowView)listBoxRestaurant.SelectedItem)["idRestaurants"]);
                DataTable dataTable = oDataSet1.Tables["Reservation"];
                if (dataTable.Rows.Count > 0)
                    labelChiffreDAffaire.Text = dataTable.Compute("Sum(prixTotal)", "").ToString();
                else
                {
                    labelChiffreDAffaire.Text = "0";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 oForm1 = new Form1();
            oForm1.Closed += (s, args) => this.Close();
            oForm1.MdiParent = this.MdiParent;
            oForm1.Show();
        }

        private void listBoxRestaurant_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet oDataSet = Manage.GetReservationByRestaurantAndDate(dateTimePicker1.Value.Date, (Int32)((DataRowView)listBoxRestaurant.SelectedItem)["idRestaurants"]);
                DataTable dataTable = oDataSet.Tables["Reservation"];
                if (dataTable.Rows.Count > 0)
                    labelChiffreDAffaire.Text = dataTable.Compute("Sum(prixTotal)", "").ToString();
                else
                {
                    labelChiffreDAffaire.Text = "0";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet oDataSet = Manage.GetReservationByRestaurantAndDate(dateTimePicker1.Value.Date, (Int32)((DataRowView)listBoxRestaurant.SelectedItem)["idRestaurants"]);
                DataTable dataTable = oDataSet.Tables["Reservation"];
                if (dataTable.Rows.Count > 0)
                    labelChiffreDAffaire.Text = dataTable.Compute("Sum(prixTotal)", "").ToString();
                else
                {
                    labelChiffreDAffaire.Text = "0";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}
