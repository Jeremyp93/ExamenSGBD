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
    public partial class CompositionReservation : Form
    {
        private int idReservation, idRestaurant;
        public CompositionReservation(int idReservation, int idRestaurant)
        {
            InitializeComponent();
            this.idReservation = idReservation;
            this.idRestaurant = idRestaurant;
        }

        private void comboBoxParticipant_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet oDataSet = Manage.GetParticipantsParReservation(idReservation);
                int valEntree = -1;
                int valPlat = -1;
                int valDessert = -1;
                int valTotal = -1;
                int valMenu = -1;
                foreach (DataTable dt in oDataSet.Tables)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        foreach (DataColumn dc in dt.Columns)
                        {
                            if (dc.ColumnName.Equals("entree"))
                            {
                                if (dr["prenom"].ToString().Equals(((DataRowView)comboBoxParticipant.SelectedItem)["prenom"]))
                                {
                                    valEntree = (Int32)dr[dr.Table.Columns["entree"].Ordinal];
                                }
                            }

                            if (dc.ColumnName.Equals("plat"))
                            {
                                if (dr["prenom"].ToString().Equals(((DataRowView)comboBoxParticipant.SelectedItem)["prenom"]))
                                {
                                    valPlat = (Int32)dr[dr.Table.Columns["plat"].Ordinal];
                                }
                            }

                            if (dc.ColumnName.Equals("dessert"))
                            {
                                if (dr["prenom"].ToString().Equals(((DataRowView)comboBoxParticipant.SelectedItem)["prenom"]))
                                {
                                    valDessert = (Int32)dr[dr.Table.Columns["dessert"].Ordinal];
                                }
                            }

                            if (dc.ColumnName.Equals("prixParPersonne"))
                            {
                                if (dr["prenom"].ToString().Equals(((DataRowView)comboBoxParticipant.SelectedItem)["prenom"]))
                                {
                                    valTotal = (Int32)dr[dr.Table.Columns["prixParPersonne"].Ordinal];
                                }
                            }

                            if (dc.ColumnName.Equals("idMenu"))
                            {
                                if (dr["prenom"].ToString().Equals(((DataRowView)comboBoxParticipant.SelectedItem)["prenom"]))
                                {
                                    if (!dr.IsNull("idMenu"))
                                        valMenu = (Int32)dr[dr.Table.Columns["idMenu"].Ordinal];
                                }
                            }
                        }
                    }
                }
                labelEntree.Text = Manage.GetElement(valEntree);
                labelPlat.Text = Manage.GetElement(valPlat);
                labelDessert.Text = Manage.GetElement(valDessert);
                labelPrixEntree.Text = Manage.GetPrixElement(valEntree).ToString();
                labelPrixPlat.Text = Manage.GetPrixElement(valPlat).ToString();
                labelPrixDessert.Text = Manage.GetPrixElement(valDessert).ToString();
                labelPrixTotal.Text = valTotal.ToString();
                if (valMenu != -1)
                    labelMenu.Text = "Menu : " + valMenu;
                else
                {
                    labelMenu.Text = "";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CompositionReservation_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet oDataSet = Manage.GetParticipantsParReservation(idReservation);
                comboBoxParticipant.DataSource = oDataSet.Tables["Participants"];
                comboBoxParticipant.DisplayMember = "prenom";
                comboBoxParticipant.ValueMember = "idDetailReservation";
                int valEntree = -1;
                int valPlat = -1;
                int valDessert = -1;
                int valTotal = -1;
                foreach (DataTable dt in oDataSet.Tables)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        foreach (DataColumn dc in dt.Columns)
                        {
                            if (dc.ColumnName.Equals("entree"))
                            {
                                if (dr["prenom"].ToString().Equals(((DataRowView)comboBoxParticipant.SelectedItem)["prenom"]))
                                {
                                    valEntree = (Int32)dr[dr.Table.Columns["entree"].Ordinal];
                                }
                            }

                            if (dc.ColumnName.Equals("plat"))
                            {
                                if (dr["prenom"].ToString().Equals(((DataRowView)comboBoxParticipant.SelectedItem)["prenom"]))
                                {
                                    valPlat = (Int32)dr[dr.Table.Columns["plat"].Ordinal];
                                }
                            }

                            if (dc.ColumnName.Equals("dessert"))
                            {
                                if (dr["prenom"].ToString().Equals(((DataRowView)comboBoxParticipant.SelectedItem)["prenom"]))
                                {
                                    valDessert = (Int32)dr[dr.Table.Columns["dessert"].Ordinal];
                                }
                            }

                            if (dc.ColumnName.Equals("prixParPersonne"))
                            {
                                if (dr["prenom"].ToString().Equals(((DataRowView)comboBoxParticipant.SelectedItem)["prenom"]))
                                {
                                    valTotal = (Int32)dr[dr.Table.Columns["prixParPersonne"].Ordinal];
                                }
                            }
                        }
                    }
                }
                labelEntree.Text = Manage.GetElement(valEntree);
                labelPlat.Text = Manage.GetElement(valPlat);
                labelDessert.Text = Manage.GetElement(valDessert);
                labelPrixEntree.Text = Manage.GetPrixElement(valEntree).ToString();
                labelPrixPlat.Text = Manage.GetPrixElement(valPlat).ToString();
                labelPrixDessert.Text = Manage.GetPrixElement(valDessert).ToString();
                labelPrixTotal.Text = valTotal.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            
        }
    }
}
