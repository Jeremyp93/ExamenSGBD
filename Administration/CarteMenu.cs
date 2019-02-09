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
    public partial class CarteMenu : Form
    {
        private int idRestaurant, idGroupe;
        public CarteMenu(int idRestaurant, int idGroupe)
        {
            InitializeComponent();
            this.idRestaurant = idRestaurant;
            this.idGroupe = idGroupe;
        }

        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet oDataSet4 = Manage.GetCarteMenuNoLinq((Int32)((DataRowView)comboBoxMenu.SelectedItem)["idMenu"], 1);
                listBoxEntreeChoisie.DataSource = oDataSet4.Tables["CarteMenus"];
                listBoxEntreeChoisie.DisplayMember = "Element";
                listBoxEntreeChoisie.ValueMember = "idCarteRestaurant";

                DataSet oDataSet5 = Manage.GetCarteMenuNoLinq((Int32)((DataRowView)comboBoxMenu.SelectedItem)["idMenu"], 2);
                listBoxPlatChoisi.DataSource = oDataSet5.Tables["CarteMenus"];
                listBoxPlatChoisi.DisplayMember = "Element";
                listBoxPlatChoisi.ValueMember = "idCarteRestaurant";

                DataSet oDataSet6 = Manage.GetCarteMenuNoLinq((Int32)((DataRowView)comboBoxMenu.SelectedItem)["idMenu"], 3);
                listBoxDessertChoisi.DataSource = oDataSet6.Tables["CarteMenus"];
                listBoxDessertChoisi.DisplayMember = "Element";
                listBoxDessertChoisi.ValueMember = "idCarteRestaurant";

                if (listBoxEntreeChoisie.Items.Count != 0 && listBoxPlatChoisi.Items.Count != 0 && listBoxDessertChoisi.Items.Count != 0)
                {
                    var selectedEntree = (Int32)((DataRowView)listBoxEntreeChoisie.SelectedItem)["idcarteRestaurant"];
                    var selectedPlat = (Int32)((DataRowView)listBoxPlatChoisi.SelectedItem)["idcarteRestaurant"];
                    var selectedDessert = (Int32)((DataRowView)listBoxDessertChoisi.SelectedItem)["idcarteRestaurant"];
                    labelPrix.Text = (Convert.ToInt32((Manage.GetPrixGroupe(selectedEntree) + Manage.GetPrixGroupe(selectedPlat) + Manage.GetPrixGroupe(selectedDessert)) * 0.9)).ToString() + " €";
                }
                else
                    labelPrix.Text = "...";
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

        private void buttonAddEntree_Click(object sender, EventArgs e)
        {
            try
            {
                Manage.InsertCarteRestaurantMenu((Int32)((DataRowView)comboBoxMenu.SelectedItem)["idMenu"], (Int32)((DataRowView)listBoxEntree.SelectedItem)["idCarteRestaurant"]);

                DataSet oDataSet = Manage.GetCarteMenuNoLinq((Int32)((DataRowView)comboBoxMenu.SelectedItem)["idMenu"], 1);
                listBoxEntreeChoisie.DataSource = oDataSet.Tables["CarteMenus"];
                listBoxEntreeChoisie.DisplayMember = "Element";
                listBoxEntreeChoisie.ValueMember = "idCarteRestaurant";
                if (buttonDeleteEntree.Enabled == false)
                {
                    buttonDeleteEntree.Enabled = true;
                    if (listBoxEntreeChoisie.Items.Count != 0 && listBoxPlatChoisi.Items.Count != 0 && listBoxDessertChoisi.Items.Count != 0)
                    {
                        var selectedEntree = (Int32)((DataRowView)listBoxEntreeChoisie.SelectedItem)["idcarteRestaurant"];
                        var selectedPlat = (Int32)((DataRowView)listBoxPlatChoisi.SelectedItem)["idcarteRestaurant"];
                        var selectedDessert = (Int32)((DataRowView)listBoxDessertChoisi.SelectedItem)["idcarteRestaurant"];
                        labelPrix.Text = (Convert.ToInt32((Manage.GetPrixGroupe(selectedEntree) + Manage.GetPrixGroupe(selectedPlat) + Manage.GetPrixGroupe(selectedDessert)) * 0.9)).ToString() + " €";
                    }
                    else
                        labelPrix.Text = "...";
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
                Manage.InsertCarteRestaurantMenu((Int32)((DataRowView)comboBoxMenu.SelectedItem)["idMenu"], (Int32)((DataRowView)listBoxPlat.SelectedItem)["idCarteRestaurant"]);

                DataSet oDataSet = Manage.GetCarteMenuNoLinq((Int32)((DataRowView)comboBoxMenu.SelectedItem)["idMenu"], 2);
                listBoxPlatChoisi.DataSource = oDataSet.Tables["CarteMenus"];
                listBoxPlatChoisi.DisplayMember = "Element";
                listBoxPlatChoisi.ValueMember = "idCarteRestaurant";
                if (buttonDeletePlat.Enabled == false)
                {
                    buttonDeletePlat.Enabled = true;
                    if (listBoxEntreeChoisie.Items.Count != 0 && listBoxPlatChoisi.Items.Count != 0 && listBoxDessertChoisi.Items.Count != 0)
                    {
                        var selectedEntree = (Int32)((DataRowView)listBoxEntreeChoisie.SelectedItem)["idcarteRestaurant"];
                        var selectedPlat = (Int32)((DataRowView)listBoxPlatChoisi.SelectedItem)["idcarteRestaurant"];
                        var selectedDessert = (Int32)((DataRowView)listBoxDessertChoisi.SelectedItem)["idcarteRestaurant"];
                        labelPrix.Text = (Convert.ToInt32((Manage.GetPrixGroupe(selectedEntree) + Manage.GetPrixGroupe(selectedPlat) + Manage.GetPrixGroupe(selectedDessert)) * 0.9)).ToString() + " €";
                    }
                    else
                        labelPrix.Text = "...";
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
                Manage.InsertCarteRestaurantMenu((Int32)((DataRowView)comboBoxMenu.SelectedItem)["idMenu"], (Int32)((DataRowView)listBoxDessert.SelectedItem)["idCarteRestaurant"]);

                DataSet oDataSet = Manage.GetCarteMenuNoLinq((Int32)((DataRowView)comboBoxMenu.SelectedItem)["idMenu"], 3);
                listBoxDessertChoisi.DataSource = oDataSet.Tables["CarteMenus"];
                listBoxDessertChoisi.DisplayMember = "Element";
                listBoxDessertChoisi.ValueMember = "idCarteRestaurant";
                if (buttonDeleteDessert.Enabled == false)
                {
                    buttonDeleteDessert.Enabled = true;
                    if (listBoxEntreeChoisie.Items.Count != 0 && listBoxPlatChoisi.Items.Count != 0 && listBoxDessertChoisi.Items.Count != 0)
                    {
                        var selectedEntree = (Int32)((DataRowView)listBoxEntreeChoisie.SelectedItem)["idcarteRestaurant"];
                        var selectedPlat = (Int32)((DataRowView)listBoxPlatChoisi.SelectedItem)["idcarteRestaurant"];
                        var selectedDessert = (Int32)((DataRowView)listBoxDessertChoisi.SelectedItem)["idcarteRestaurant"];
                        labelPrix.Text = (Convert.ToInt32((Manage.GetPrixGroupe(selectedEntree) + Manage.GetPrixGroupe(selectedPlat) + Manage.GetPrixGroupe(selectedDessert)) * 0.9)).ToString() + " €";
                    }
                    else
                        labelPrix.Text = "...";
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
                int id = Manage.GetIdDetailMenu((Int32)((DataRowView)comboBoxMenu.SelectedItem)["idMenu"], (Int32)((DataRowView)listBoxEntreeChoisie.SelectedItem)["idCarteRestaurant"]);
                Manage.DeleteCarteRestaurantMenu(id);

                DataSet oDataSet = Manage.GetCarteMenuNoLinq((Int32)((DataRowView)comboBoxMenu.SelectedItem)["idMenu"], 1);
                listBoxEntreeChoisie.DataSource = oDataSet.Tables["CarteMenus"];
                listBoxEntreeChoisie.DisplayMember = "Element";
                listBoxEntreeChoisie.ValueMember = "idCarteRestaurant";

                if (listBoxEntreeChoisie.Items.Count == 0)
                {
                    buttonDeleteEntree.Enabled = false;
                    labelPrix.Text = "...";
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
                int id = Manage.GetIdDetailMenu((Int32)((DataRowView)comboBoxMenu.SelectedItem)["idMenu"], (Int32)((DataRowView)listBoxPlatChoisi.SelectedItem)["idCarteRestaurant"]);
                Manage.DeleteCarteRestaurantMenu(id);

                DataSet oDataSet = Manage.GetCarteMenuNoLinq((Int32)((DataRowView)comboBoxMenu.SelectedItem)["idMenu"], 2);
                listBoxPlatChoisi.DataSource = oDataSet.Tables["CarteMenus"];
                listBoxPlatChoisi.DisplayMember = "Element";
                listBoxPlatChoisi.ValueMember = "idCarteRestaurant";

                if (listBoxPlatChoisi.Items.Count == 0)
                {
                    buttonDeletePlat.Enabled = false;
                    labelPrix.Text = "...";
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
                int id = Manage.GetIdDetailMenu((Int32)((DataRowView)comboBoxMenu.SelectedItem)["idMenu"], (Int32)((DataRowView)listBoxDessertChoisi.SelectedItem)["idCarteRestaurant"]);
                Manage.DeleteCarteRestaurantMenu(id);

                DataSet oDataSet = Manage.GetCarteMenuNoLinq((Int32)((DataRowView)comboBoxMenu.SelectedItem)["idMenu"], 3);
                listBoxDessertChoisi.DataSource = oDataSet.Tables["CarteMenus"];
                listBoxDessertChoisi.DisplayMember = "Element";
                listBoxDessertChoisi.ValueMember = "idCarteRestaurant";

                if (listBoxDessertChoisi.Items.Count == 0)
                {
                    buttonDeleteDessert.Enabled = false;
                    labelPrix.Text = "...";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Manage.InsertMenu(idRestaurant);

                DataSet oDataSet0 = Manage.SelectMenuByRestaurant(idRestaurant);
                comboBoxMenu.DataSource = oDataSet0.Tables["Menus"];
                comboBoxMenu.DisplayMember = "idMenu";
                comboBoxMenu.ValueMember = "idMenu";
                comboBoxMenu.SelectedIndex = comboBoxMenu.Items.Count - 1;

                buttonAddEntree.Enabled = true;
                buttonAddPlat.Enabled = true;
                buttonAddDessert.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonSupprimerMenu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Manage.SelectidMenuReservation().Contains((Int32)((DataRowView)comboBoxMenu.SelectedItem)["idMenu"]))
                {
                    Manage.DeleteMenu((Int32)((DataRowView)comboBoxMenu.SelectedItem)["idMenu"]);

                    DataSet oDataSet0 = Manage.SelectMenuByRestaurant(idRestaurant);
                    if (oDataSet0.Tables["Menus"].Rows.Count != 0)
                    {
                        comboBoxMenu.DataSource = oDataSet0.Tables["Menus"];
                        comboBoxMenu.DisplayMember = "idMenu";
                        comboBoxMenu.ValueMember = "idMenu";
                        comboBoxMenu.SelectedIndex = 0;
                    }
                    else
                    {
                        buttonAddEntree.Enabled = false;
                        buttonAddPlat.Enabled = false;
                        buttonAddDessert.Enabled = false;
                        buttonDeleteEntree.Enabled = false;
                        buttonDeletePlat.Enabled = false;
                        buttonDeleteDessert.Enabled = false;
                        buttonSupprimerMenu.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Le menu ne peut être supprimé car il est commandé par un client !");
                }
                
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void listBoxEntreeChoisie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEntreeChoisie.Items.Count != 0 && listBoxPlatChoisi.Items.Count != 0 && listBoxDessertChoisi.Items.Count != 0)
            {
                var selectedEntree = (Int32)((DataRowView)listBoxEntreeChoisie.SelectedItem)["idcarteRestaurant"];
                var selectedPlat = (Int32)((DataRowView)listBoxPlatChoisi.SelectedItem)["idcarteRestaurant"];
                var selectedDessert = (Int32)((DataRowView)listBoxDessertChoisi.SelectedItem)["idcarteRestaurant"];
                labelPrix.Text = (Convert.ToInt32((Manage.GetPrixGroupe(selectedEntree) + Manage.GetPrixGroupe(selectedPlat) + Manage.GetPrixGroupe(selectedDessert)) * 0.9)).ToString() + " €";
            }
            else
                labelPrix.Text = "...";
        }

        private void listBoxPlatChoisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEntreeChoisie.Items.Count != 0 && listBoxPlatChoisi.Items.Count != 0 && listBoxDessertChoisi.Items.Count != 0)
            {
                var selectedEntree = (Int32)((DataRowView)listBoxEntreeChoisie.SelectedItem)["idcarteRestaurant"];
                var selectedPlat = (Int32)((DataRowView)listBoxPlatChoisi.SelectedItem)["idcarteRestaurant"];
                var selectedDessert = (Int32)((DataRowView)listBoxDessertChoisi.SelectedItem)["idcarteRestaurant"];
                labelPrix.Text = (Convert.ToInt32((Manage.GetPrixGroupe(selectedEntree) + Manage.GetPrixGroupe(selectedPlat) + Manage.GetPrixGroupe(selectedDessert)) * 0.9)).ToString() + " €";
            }
            else
                labelPrix.Text = "...";
        }

        private void listBoxDessertChoisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEntreeChoisie.Items.Count != 0 && listBoxPlatChoisi.Items.Count != 0 && listBoxDessertChoisi.Items.Count != 0)
            {
                var selectedEntree = (Int32)((DataRowView)listBoxEntreeChoisie.SelectedItem)["idcarteRestaurant"];
                var selectedPlat = (Int32)((DataRowView)listBoxPlatChoisi.SelectedItem)["idcarteRestaurant"];
                var selectedDessert = (Int32)((DataRowView)listBoxDessertChoisi.SelectedItem)["idcarteRestaurant"];
                labelPrix.Text = (Convert.ToInt32((Manage.GetPrixGroupe(selectedEntree) + Manage.GetPrixGroupe(selectedPlat) + Manage.GetPrixGroupe(selectedDessert)) * 0.9)).ToString() + " €";
            }
            else
                labelPrix.Text = "...";
        }

        private void CarteMenu_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet oDataSet = Manage.SelectCarteRestaurantByType(idRestaurant, 1);
                listBoxEntree.DataSource = oDataSet.Tables["CarteRestaurant"];
                listBoxEntree.DisplayMember = "Element";
                listBoxEntree.ValueMember = "idCarteRestaurant";

                DataSet oDataSet2 = Manage.SelectCarteRestaurantByType(idRestaurant, 2);
                listBoxPlat.DataSource = oDataSet2.Tables["CarteRestaurant"];
                listBoxPlat.DisplayMember = "Element";
                listBoxPlat.ValueMember = "idCarteRestaurant";

                DataSet oDataSet3 = Manage.SelectCarteRestaurantByType(idRestaurant, 3);
                listBoxDessert.DataSource = oDataSet3.Tables["CarteRestaurant"];
                listBoxDessert.DisplayMember = "Element";
                listBoxDessert.ValueMember = "idCarteRestaurant";

                DataSet oDataSet0 = Manage.SelectMenuByRestaurant(idRestaurant);
                if (oDataSet0.Tables["Menus"].Rows.Count != 0)
                {
                    buttonSupprimerMenu.Enabled = true;
                    comboBoxMenu.DataSource = oDataSet0.Tables["Menus"];
                    comboBoxMenu.DisplayMember = "idMenu";
                    comboBoxMenu.ValueMember = "idMenu";

                    DataSet oDataSet4 = Manage.GetCarteMenuNoLinq((Int32)((DataRowView)comboBoxMenu.SelectedItem)["idMenu"], 1);
                    if (oDataSet4.Tables["CarteMenus"].Rows.Count != 0)
                    {
                        listBoxEntreeChoisie.DataSource = oDataSet4.Tables["CarteMenus"];
                        listBoxEntreeChoisie.DisplayMember = "Element";
                        listBoxEntreeChoisie.ValueMember = "idCarteRestaurant";
                    }
                    else
                    {
                        buttonDeleteEntree.Enabled = false;
                    }

                    DataSet oDataSet5 = Manage.GetCarteMenuNoLinq((Int32)((DataRowView)comboBoxMenu.SelectedItem)["idMenu"], 2);
                    if (oDataSet5.Tables["CarteMenus"].Rows.Count != 0)
                    {
                        listBoxPlatChoisi.DataSource = oDataSet5.Tables["CarteMenus"];
                        listBoxPlatChoisi.DisplayMember = "Element";
                        listBoxPlatChoisi.ValueMember = "idCarteRestaurant";
                    }
                    else
                    {
                        buttonDeletePlat.Enabled = false;
                    }

                    DataSet oDataSet6 = Manage.GetCarteMenuNoLinq((Int32)((DataRowView)comboBoxMenu.SelectedItem)["idMenu"], 3);
                    if (oDataSet6.Tables["CarteMenus"].Rows.Count != 0)
                    {
                        listBoxDessertChoisi.DataSource = oDataSet6.Tables["CarteMenus"];
                        listBoxDessertChoisi.DisplayMember = "Element";
                        listBoxDessertChoisi.ValueMember = "idCarteRestaurant";
                    }
                    else
                    {
                        buttonDeleteDessert.Enabled = false;
                    }

                    if (listBoxEntreeChoisie.Items.Count != 0 && listBoxPlatChoisi.Items.Count != 0 && listBoxDessertChoisi.Items.Count != 0)
                    {
                        var selectedEntree = (Int32)((DataRowView)listBoxEntreeChoisie.SelectedItem)["idcarteRestaurant"];
                        var selectedPlat = (Int32)((DataRowView)listBoxPlatChoisi.SelectedItem)["idcarteRestaurant"];
                        var selectedDessert = (Int32)((DataRowView)listBoxDessertChoisi.SelectedItem)["idcarteRestaurant"];
                        labelPrix.Text = (Convert.ToInt32((Manage.GetPrixGroupe(selectedEntree) + Manage.GetPrixGroupe(selectedPlat) + Manage.GetPrixGroupe(selectedDessert)) * 0.9)).ToString() + " €";
                    }
                    else
                        labelPrix.Text = "...";
                }
                else
                {
                    buttonAddEntree.Enabled = false;
                    buttonAddPlat.Enabled = false;
                    buttonAddDessert.Enabled = false;
                    buttonDeleteEntree.Enabled = false;
                    buttonDeletePlat.Enabled = false;
                    buttonDeleteDessert.Enabled = false;
                    buttonSupprimerMenu.Enabled = false;
                } 
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
