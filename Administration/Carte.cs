using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Administration
{
    public partial class Carte : Form
    {
        private int idRestaurant,idGroupe;
        public Carte(int idRestaurant, int idGroupe)
        {
            InitializeComponent();
            this.idRestaurant = idRestaurant;
            this.idGroupe = idGroupe;
        }

        private void Carte_Load(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine(idRestaurant.ToString());
                DataSet oDataSet = BusinessLayer.Manage.SelectCarteByType(idGroupe, 1);
                listBoxEntree.DataSource = oDataSet.Tables["CarteGroupe"];
                listBoxEntree.DisplayMember = "Element";
                listBoxEntree.ValueMember = "idCarteGroupe";
                listBoxEntree.SelectedIndex = 0;

                DataSet oDataSet2 = BusinessLayer.Manage.SelectCarteByType(idGroupe, 2);
                listBoxPlat.DataSource = oDataSet2.Tables["CarteGroupe"];
                listBoxPlat.DisplayMember = "Element";
                listBoxPlat.ValueMember = "idCarteGroupe";
                listBoxPlat.SelectedIndex = 0;

                DataSet oDataSet3 = BusinessLayer.Manage.SelectCarteByType(idGroupe, 3);
                listBoxDessert.DataSource = oDataSet3.Tables["CarteGroupe"];
                listBoxDessert.DisplayMember = "Element";
                listBoxDessert.ValueMember = "idCarteGroupe";
                listBoxDessert.SelectedIndex = 0;

                DataSet oDataSet4 = BusinessLayer.Manage.SelectCarteRestaurantByType(idRestaurant, 1);
                listBoxEntreeChoisie.DataSource = oDataSet4.Tables["CarteRestaurant"];
                listBoxEntreeChoisie.DisplayMember = "Element";
                listBoxEntreeChoisie.ValueMember = "idCarteRestaurant";

                DataSet oDataSet5 = BusinessLayer.Manage.SelectCarteRestaurantByType(idRestaurant, 2);
                listBoxPlatChoisi.DataSource = oDataSet5.Tables["CarteRestaurant"];
                listBoxPlatChoisi.DisplayMember = "Element";
                listBoxPlatChoisi.ValueMember = "idCarteRestaurant";

                DataSet oDataSet6 = BusinessLayer.Manage.SelectCarteRestaurantByType(idRestaurant, 3);
                listBoxDessertChoisi.DataSource = oDataSet6.Tables["CarteRestaurant"];
                listBoxDessertChoisi.DisplayMember = "Element";
                listBoxDessertChoisi.ValueMember = "idCarteRestaurant";

                if (listBoxEntreeChoisie.Items.Count == 0)
                {
                    buttonValideEntree.Enabled = false;
                    buttonDeleteEntree.Enabled = false;
                }

                if (listBoxPlatChoisi.Items.Count == 0)
                {
                    buttonValidePlat.Enabled = false;
                    buttonDeletePlat.Enabled = false;
                }

                if (listBoxDessertChoisi.Items.Count == 0)
                {
                    buttonValideDessert.Enabled = false;
                    buttonDeleteDessert.Enabled = false;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonAddPlat_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLayer.Manage.InsertCarteRestaurant(idRestaurant, (Int32)((DataRowView)listBoxPlat.SelectedItem)["idCarteGroupe"]);

                DataSet oDataSet = BusinessLayer.Manage.SelectCarteRestaurantByType(idRestaurant, 2);
                listBoxPlatChoisi.DataSource = oDataSet.Tables["CarteRestaurant"];
                listBoxPlatChoisi.DisplayMember = "Element";
                listBoxPlatChoisi.ValueMember = "idCarteRestaurant";
                if (buttonValidePlat.Enabled == false)
                {
                    buttonValidePlat.Enabled = true;
                    buttonDeletePlat.Enabled = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonAddDessert_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLayer.Manage.InsertCarteRestaurant(idRestaurant, (Int32)((DataRowView)listBoxDessert.SelectedItem)["idCarteGroupe"]);

                DataSet oDataSet = BusinessLayer.Manage.SelectCarteRestaurantByType(idRestaurant, 3);
                listBoxDessertChoisi.DataSource = oDataSet.Tables["CarteRestaurant"];
                listBoxDessertChoisi.DisplayMember = "Element";
                listBoxDessertChoisi.ValueMember = "idCarteRestaurant";
                if (buttonValideDessert.Enabled == false)
                {
                    buttonValideDessert.Enabled = true;
                    buttonDeleteDessert.Enabled = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonDeleteEntree_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLayer.Manage.DeleteCarteRestaurant((Int32)((DataRowView)listBoxEntreeChoisie.SelectedItem)["idCarteRestaurant"]);

                DataSet oDataSet = BusinessLayer.Manage.SelectCarteRestaurantByType(idRestaurant, 1);
                listBoxEntreeChoisie.DataSource = oDataSet.Tables["CarteRestaurant"];
                listBoxEntreeChoisie.DisplayMember = "Element";
                listBoxEntreeChoisie.ValueMember = "idCarteRestaurant";
                if (listBoxEntreeChoisie.Items.Count == 0)
                {
                    buttonValideEntree.Enabled = false;
                    buttonDeleteEntree.Enabled = false;
                    labelPrixMinimum.Text = "";
                    textBoxPrix.Text = "";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonDeletePlat_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLayer.Manage.DeleteCarteRestaurant((Int32)((DataRowView)listBoxPlatChoisi.SelectedItem)["idCarteRestaurant"]);

                DataSet oDataSet = BusinessLayer.Manage.SelectCarteRestaurantByType(idRestaurant, 2);
                listBoxPlatChoisi.DataSource = oDataSet.Tables["CarteRestaurant"];
                listBoxPlatChoisi.DisplayMember = "Element";
                listBoxPlatChoisi.ValueMember = "idCarteRestaurant";
                if (listBoxPlatChoisi.Items.Count == 0)
                {
                    buttonValidePlat.Enabled = false;
                    buttonDeletePlat.Enabled = false;
                    labelPrixMinimumPlat.Text = "";
                    textBoxPrixPlat.Text = "";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonDeleteDessert_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLayer.Manage.DeleteCarteRestaurant((Int32)((DataRowView)listBoxDessertChoisi.SelectedItem)["idCarteRestaurant"]);

                DataSet oDataSet = BusinessLayer.Manage.SelectCarteRestaurantByType(idRestaurant, 3);
                listBoxDessertChoisi.DataSource = oDataSet.Tables["CarteRestaurant"];
                listBoxDessertChoisi.DisplayMember = "Element";
                listBoxDessertChoisi.ValueMember = "idCarteRestaurant";
                if (listBoxDessertChoisi.Items.Count == 0)
                {
                    buttonValideDessert.Enabled = false;
                    buttonDeleteDessert.Enabled = false;
                    labelPrixMinimumDessert.Text = "";
                    textBoxPrixDessert.Text = "";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxEntreeChoisie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                labelPrixMinimum.Text = BusinessLayer.Manage.SelectPrixMinmumGroupe(
                    (Int32)((DataRowView)listBoxEntreeChoisie.SelectedItem)["idCarteGroupe"]);
                textBoxPrix.Text =
                    BusinessLayer.Manage.SelectPrixCarte(
                        (Int32)((DataRowView)listBoxEntreeChoisie.SelectedItem)["idCarteRestaurant"]);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void listBoxPlatChoisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                labelPrixMinimumPlat.Text = BusinessLayer.Manage.SelectPrixMinmumGroupe(
                    (Int32)((DataRowView)listBoxPlatChoisi.SelectedItem)["idCarteGroupe"]);
                textBoxPrixPlat.Text =
                    BusinessLayer.Manage.SelectPrixCarte(
                        (Int32)((DataRowView)listBoxPlatChoisi.SelectedItem)["idCarteRestaurant"]);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void listBoxDessertChoisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                labelPrixMinimumDessert.Text = BusinessLayer.Manage.SelectPrixMinmumGroupe(
                    (Int32)((DataRowView)listBoxDessertChoisi.SelectedItem)["idCarteGroupe"]);
                textBoxPrixDessert.Text =
                    BusinessLayer.Manage.SelectPrixCarte(
                        (Int32)((DataRowView)listBoxDessertChoisi.SelectedItem)["idCarteRestaurant"]);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonValideEntree_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLayer.Manage.UpdatePrixCarteRestaurant((Int32)((DataRowView)listBoxEntreeChoisie.SelectedItem)["idCarteRestaurant"], Int32.Parse(textBoxPrix.Text));

                labelPrixMinimum.Text = BusinessLayer.Manage.SelectPrixMinmumGroupe(
                    (Int32)((DataRowView)listBoxEntreeChoisie.SelectedItem)["idCarteGroupe"]);
                textBoxPrix.Text =
                    BusinessLayer.Manage.SelectPrixCarte(
                        (Int32)((DataRowView)listBoxEntreeChoisie.SelectedItem)["idCarteRestaurant"]);
            }
            catch (Exception exception)
            {
                labelPrixMinimum.Text = BusinessLayer.Manage.SelectPrixMinmumGroupe(
                    (Int32)((DataRowView)listBoxEntreeChoisie.SelectedItem)["idCarteGroupe"]);
                textBoxPrix.Text =
                    BusinessLayer.Manage.SelectPrixCarte(
                        (Int32)((DataRowView)listBoxEntreeChoisie.SelectedItem)["idCarteRestaurant"]);
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonValidePlat_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLayer.Manage.UpdatePrixCarteRestaurant((Int32)((DataRowView)listBoxPlatChoisi.SelectedItem)["idCarteRestaurant"], Int32.Parse(textBoxPrixPlat.Text));

                labelPrixMinimumPlat.Text = BusinessLayer.Manage.SelectPrixMinmumGroupe(
                    (Int32)((DataRowView)listBoxPlatChoisi.SelectedItem)["idCarteGroupe"]);
                textBoxPrixPlat.Text =
                    BusinessLayer.Manage.SelectPrixCarte(
                        (Int32)((DataRowView)listBoxPlatChoisi.SelectedItem)["idCarteRestaurant"]);
            }
            catch (Exception exception)
            {
                labelPrixMinimumPlat.Text = BusinessLayer.Manage.SelectPrixMinmumGroupe(
                    (Int32)((DataRowView)listBoxPlatChoisi.SelectedItem)["idCarteGroupe"]);
                textBoxPrixPlat.Text =
                    BusinessLayer.Manage.SelectPrixCarte(
                        (Int32)((DataRowView)listBoxPlatChoisi.SelectedItem)["idCarteRestaurant"]);
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonValideDessert_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLayer.Manage.UpdatePrixCarteRestaurant((Int32)((DataRowView)listBoxDessertChoisi.SelectedItem)["idCarteRestaurant"], Int32.Parse(textBoxPrixDessert.Text));

                labelPrixMinimumDessert.Text = BusinessLayer.Manage.SelectPrixMinmumGroupe(
                    (Int32)((DataRowView)listBoxDessertChoisi.SelectedItem)["idCarteGroupe"]);
                textBoxPrixDessert.Text =
                    BusinessLayer.Manage.SelectPrixCarte(
                        (Int32)((DataRowView)listBoxDessertChoisi.SelectedItem)["idCarteRestaurant"]);
            }
            catch (Exception exception)
            {
                labelPrixMinimumDessert.Text = BusinessLayer.Manage.SelectPrixMinmumGroupe(
                    (Int32)((DataRowView)listBoxDessertChoisi.SelectedItem)["idCarteGroupe"]);
                textBoxPrixDessert.Text =
                    BusinessLayer.Manage.SelectPrixCarte(
                        (Int32)((DataRowView)listBoxDessertChoisi.SelectedItem)["idCarteRestaurant"]);
                MessageBox.Show(exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarteMenu oCarteMenu = new CarteMenu(idRestaurant, idGroupe);
            oCarteMenu.Closed += (s, args) => this.Close();
            oCarteMenu.MdiParent = this.MdiParent;
            oCarteMenu.Show();
        }

        private void buttonAddEntree_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLayer.Manage.InsertCarteRestaurant(idRestaurant, (Int32)((DataRowView)listBoxEntree.SelectedItem)["idCarteGroupe"]);

                DataSet oDataSet = BusinessLayer.Manage.SelectCarteRestaurantByType(idRestaurant, 1);
                listBoxEntreeChoisie.DataSource = oDataSet.Tables["CarteRestaurant"];
                listBoxEntreeChoisie.DisplayMember = "Element";
                listBoxEntreeChoisie.ValueMember = "idCarteRestaurant";
                if (buttonValideEntree.Enabled == false)
                {
                    buttonValideEntree.Enabled = true;
                    buttonDeleteEntree.Enabled = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
