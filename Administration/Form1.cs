using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet oDataSet = BusinessLayer.Manage.SelectGroupes();
                listBoxGroupe.DataSource = oDataSet.Tables["Groupes"];
                listBoxGroupe.DisplayMember = "Groupe";
                listBoxGroupe.ValueMember = "idGroupes";
                listBoxGroupe.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonCarte_Click(object sender, EventArgs e)
        {
            try
            {
                Carte oCarte = new Carte((Int32)((DataRowView)listBoxRestaurant.SelectedItem)["idRestaurants"], (Int32)((DataRowView)listBoxGroupe.SelectedItem)["idGroupes"]);
                oCarte.MdiParent = this.MdiParent;
                oCarte.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void listBoxGroupe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet oDataSet = BusinessLayer.Manage.SelectRestaurantsFromGroupe((Int32)((DataRowView)listBoxGroupe.SelectedItem)["idGroupes"]);
                listBoxRestaurant.DataSource = oDataSet.Tables["Restaurants"];
                listBoxRestaurant.DisplayMember = "Resto";
                listBoxRestaurant.ValueMember = "idRestaurants";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonDetailResto_Click(object sender, EventArgs e)
        {
            this.Hide();
            DetailRestaurant oDetailRestaurant = new DetailRestaurant((Int32)((DataRowView)listBoxRestaurant.SelectedItem)["idRestaurants"], (Int32)((DataRowView)listBoxGroupe.SelectedItem)["idGroupes"]);
            oDetailRestaurant.Closed += (s, args) => this.Close();
            oDetailRestaurant.MdiParent = this.MdiParent;
            oDetailRestaurant.Show();
        }

        private void buttonDetailGroupe_Click(object sender, EventArgs e)
        {
            this.Hide();
            DetailGroupe oDetailGroupe = new DetailGroupe((Int32)((DataRowView)listBoxGroupe.SelectedItem)["idGroupes"]);
            oDetailGroupe.Closed += (s, args) => this.Close();
            oDetailGroupe.MdiParent = this.MdiParent;
            oDetailGroupe.Show();
        }
    }
}
