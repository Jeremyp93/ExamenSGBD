namespace Administration
{
    partial class DetailRestaurant
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelChiffreDaffaire = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.buttonComposition = new System.Windows.Forms.Button();
            this.labelTable = new System.Windows.Forms.Label();
            this.labelPlacesDispo = new System.Windows.Forms.Label();
            this.labelPlacesReservees = new System.Windows.Forms.Label();
            this.labelPrixTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(29, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 329);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chiffre d\'affaire de la journée";
            // 
            // labelChiffreDaffaire
            // 
            this.labelChiffreDaffaire.AutoSize = true;
            this.labelChiffreDaffaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChiffreDaffaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelChiffreDaffaire.Location = new System.Drawing.Point(632, 12);
            this.labelChiffreDaffaire.Name = "labelChiffreDaffaire";
            this.labelChiffreDaffaire.Size = new System.Drawing.Size(79, 33);
            this.labelChiffreDaffaire.TabIndex = 3;
            this.labelChiffreDaffaire.Text = "2600";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(707, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "€";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Table :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(368, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre de places disponnibles :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(337, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre de places reservées :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(251, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(301, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Prix total de la reservation :";
            // 
            // buttonRetour
            // 
            this.buttonRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetour.Location = new System.Drawing.Point(525, 330);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(213, 71);
            this.buttonRetour.TabIndex = 9;
            this.buttonRetour.Text = "Accueil";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // buttonComposition
            // 
            this.buttonComposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComposition.Location = new System.Drawing.Point(256, 330);
            this.buttonComposition.Name = "buttonComposition";
            this.buttonComposition.Size = new System.Drawing.Size(221, 71);
            this.buttonComposition.TabIndex = 10;
            this.buttonComposition.Text = "Composition";
            this.buttonComposition.UseVisualStyleBackColor = true;
            this.buttonComposition.Click += new System.EventHandler(this.buttonComposition_Click);
            // 
            // labelTable
            // 
            this.labelTable.AutoSize = true;
            this.labelTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTable.ForeColor = System.Drawing.Color.Blue;
            this.labelTable.Location = new System.Drawing.Point(336, 119);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(121, 29);
            this.labelTable.TabIndex = 11;
            this.labelTable.Text = "Table 123";
            // 
            // labelPlacesDispo
            // 
            this.labelPlacesDispo.AutoSize = true;
            this.labelPlacesDispo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlacesDispo.ForeColor = System.Drawing.Color.Blue;
            this.labelPlacesDispo.Location = new System.Drawing.Point(616, 148);
            this.labelPlacesDispo.Name = "labelPlacesDispo";
            this.labelPlacesDispo.Size = new System.Drawing.Size(26, 29);
            this.labelPlacesDispo.TabIndex = 12;
            this.labelPlacesDispo.Text = "4";
            // 
            // labelPlacesReservees
            // 
            this.labelPlacesReservees.AutoSize = true;
            this.labelPlacesReservees.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlacesReservees.ForeColor = System.Drawing.Color.Blue;
            this.labelPlacesReservees.Location = new System.Drawing.Point(585, 217);
            this.labelPlacesReservees.Name = "labelPlacesReservees";
            this.labelPlacesReservees.Size = new System.Drawing.Size(26, 29);
            this.labelPlacesReservees.TabIndex = 13;
            this.labelPlacesReservees.Text = "3";
            // 
            // labelPrixTotal
            // 
            this.labelPrixTotal.AutoSize = true;
            this.labelPrixTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrixTotal.ForeColor = System.Drawing.Color.Blue;
            this.labelPrixTotal.Location = new System.Drawing.Point(547, 246);
            this.labelPrixTotal.Name = "labelPrixTotal";
            this.labelPrixTotal.Size = new System.Drawing.Size(39, 29);
            this.labelPrixTotal.TabIndex = 14;
            this.labelPrixTotal.Text = "50";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(594, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "€";
            // 
            // DetailRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelPrixTotal);
            this.Controls.Add(this.labelPlacesReservees);
            this.Controls.Add(this.labelPlacesDispo);
            this.Controls.Add(this.labelTable);
            this.Controls.Add(this.buttonComposition);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelChiffreDaffaire);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "DetailRestaurant";
            this.Text = "DetailRestaurant";
            this.Load += new System.EventHandler(this.DetailRestaurant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelChiffreDaffaire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Button buttonComposition;
        private System.Windows.Forms.Label labelTable;
        private System.Windows.Forms.Label labelPlacesDispo;
        private System.Windows.Forms.Label labelPlacesReservees;
        private System.Windows.Forms.Label labelPrixTotal;
        private System.Windows.Forms.Label label7;
    }
}