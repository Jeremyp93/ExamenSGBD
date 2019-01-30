namespace Reservation
{
    partial class NouvelleReservation2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNombreDePersonnes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxRestaurant = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxNombreDePersonnes
            // 
            this.textBoxNombreDePersonnes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreDePersonnes.Location = new System.Drawing.Point(257, 252);
            this.textBoxNombreDePersonnes.Name = "textBoxNombreDePersonnes";
            this.textBoxNombreDePersonnes.Size = new System.Drawing.Size(66, 35);
            this.textBoxNombreDePersonnes.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Vous seriez combien ?";
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Location = new System.Drawing.Point(183, 63);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(183, 32);
            this.comboBoxTables.TabIndex = 14;
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuivant.Location = new System.Drawing.Point(120, 379);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(143, 47);
            this.buttonSuivant.TabIndex = 13;
            this.buttonSuivant.Text = "Suivant";
            this.buttonSuivant.UseVisualStyleBackColor = true;
            this.buttonSuivant.Click += new System.EventHandler(this.buttonSuivant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ou voulez-vous manger?";
            // 
            // listBoxRestaurant
            // 
            this.listBoxRestaurant.FormattingEnabled = true;
            this.listBoxRestaurant.Location = new System.Drawing.Point(23, 63);
            this.listBoxRestaurant.Name = "listBoxRestaurant";
            this.listBoxRestaurant.Size = new System.Drawing.Size(134, 290);
            this.listBoxRestaurant.TabIndex = 11;
            this.listBoxRestaurant.SelectedIndexChanged += new System.EventHandler(this.listBoxRestaurant_SelectedIndexChanged);
            // 
            // NouvelleReservation2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 439);
            this.Controls.Add(this.textBoxNombreDePersonnes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTables);
            this.Controls.Add(this.buttonSuivant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxRestaurant);
            this.Name = "NouvelleReservation2";
            this.Text = "NouvelleReservation2";
            this.Load += new System.EventHandler(this.NouvelleReservation2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombreDePersonnes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxRestaurant;
    }
}