namespace Reservation
{
    partial class NouvelleReservationCommande
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
            this.button_supprimer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonTerminer = new System.Windows.Forms.Button();
            this.labelDessert = new System.Windows.Forms.Label();
            this.labelPlat = new System.Windows.Forms.Label();
            this.labelEntree = new System.Windows.Forms.Label();
            this.labelPrixTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAjouterParticipants = new System.Windows.Forms.Button();
            this.listBoxPersonnesPresentes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_supprimer
            // 
            this.button_supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_supprimer.Location = new System.Drawing.Point(158, 199);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(230, 50);
            this.button_supprimer.TabIndex = 44;
            this.button_supprimer.Text = "Supprimer commande";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Visible = false;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(931, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "€";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(867, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 39);
            this.label5.TabIndex = 42;
            this.label5.Text = "Prix";
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(17, 63);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(109, 23);
            this.buttonModifier.TabIndex = 41;
            this.buttonModifier.Text = "Modifier participants";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonTerminer
            // 
            this.buttonTerminer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTerminer.Location = new System.Drawing.Point(436, 201);
            this.buttonTerminer.Name = "buttonTerminer";
            this.buttonTerminer.Size = new System.Drawing.Size(183, 45);
            this.buttonTerminer.TabIndex = 40;
            this.buttonTerminer.Text = "Terminer";
            this.buttonTerminer.UseVisualStyleBackColor = true;
            this.buttonTerminer.Click += new System.EventHandler(this.buttonTerminer_Click);
            // 
            // labelDessert
            // 
            this.labelDessert.AutoSize = true;
            this.labelDessert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDessert.Location = new System.Drawing.Point(680, 121);
            this.labelDessert.Name = "labelDessert";
            this.labelDessert.Size = new System.Drawing.Size(0, 20);
            this.labelDessert.TabIndex = 39;
            // 
            // labelPlat
            // 
            this.labelPlat.AutoSize = true;
            this.labelPlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlat.Location = new System.Drawing.Point(449, 121);
            this.labelPlat.Name = "labelPlat";
            this.labelPlat.Size = new System.Drawing.Size(0, 20);
            this.labelPlat.TabIndex = 38;
            // 
            // labelEntree
            // 
            this.labelEntree.AutoSize = true;
            this.labelEntree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntree.Location = new System.Drawing.Point(211, 121);
            this.labelEntree.Name = "labelEntree";
            this.labelEntree.Size = new System.Drawing.Size(0, 20);
            this.labelEntree.TabIndex = 37;
            // 
            // labelPrixTotal
            // 
            this.labelPrixTotal.AutoSize = true;
            this.labelPrixTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrixTotal.Location = new System.Drawing.Point(882, 121);
            this.labelPrixTotal.Name = "labelPrixTotal";
            this.labelPrixTotal.Size = new System.Drawing.Size(0, 20);
            this.labelPrixTotal.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(648, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 39);
            this.label3.TabIndex = 35;
            this.label3.Text = "Dessert";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 39);
            this.label2.TabIndex = 34;
            this.label2.Text = "Plat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 39);
            this.label1.TabIndex = 33;
            this.label1.Text = "Entree";
            // 
            // buttonAjouterParticipants
            // 
            this.buttonAjouterParticipants.Location = new System.Drawing.Point(17, 92);
            this.buttonAjouterParticipants.Name = "buttonAjouterParticipants";
            this.buttonAjouterParticipants.Size = new System.Drawing.Size(109, 23);
            this.buttonAjouterParticipants.TabIndex = 32;
            this.buttonAjouterParticipants.Text = "Ajouter participants";
            this.buttonAjouterParticipants.UseVisualStyleBackColor = true;
            this.buttonAjouterParticipants.Click += new System.EventHandler(this.buttonAjouterParticipants_Click);
            // 
            // listBoxPersonnesPresentes
            // 
            this.listBoxPersonnesPresentes.FormattingEnabled = true;
            this.listBoxPersonnesPresentes.Location = new System.Drawing.Point(17, 121);
            this.listBoxPersonnesPresentes.Name = "listBoxPersonnesPresentes";
            this.listBoxPersonnesPresentes.Size = new System.Drawing.Size(109, 121);
            this.listBoxPersonnesPresentes.TabIndex = 31;
            this.listBoxPersonnesPresentes.SelectedIndexChanged += new System.EventHandler(this.listBoxPersonnesPresentes_SelectedIndexChanged);
            // 
            // NouvelleReservationCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 269);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonTerminer);
            this.Controls.Add(this.labelDessert);
            this.Controls.Add(this.labelPlat);
            this.Controls.Add(this.labelEntree);
            this.Controls.Add(this.labelPrixTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAjouterParticipants);
            this.Controls.Add(this.listBoxPersonnesPresentes);
            this.Name = "NouvelleReservationCommande";
            this.Text = "NouvelleReservationCommande";
            this.Load += new System.EventHandler(this.NouvelleReservationCommande_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonTerminer;
        private System.Windows.Forms.Label labelDessert;
        private System.Windows.Forms.Label labelPlat;
        private System.Windows.Forms.Label labelEntree;
        private System.Windows.Forms.Label labelPrixTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAjouterParticipants;
        private System.Windows.Forms.ListBox listBoxPersonnesPresentes;
    }
}