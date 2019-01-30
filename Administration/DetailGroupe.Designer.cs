namespace Administration
{
    partial class DetailGroupe
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
            this.listBoxRestaurant = new System.Windows.Forms.ListBox();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelChiffreDAffaire = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // listBoxRestaurant
            // 
            this.listBoxRestaurant.FormattingEnabled = true;
            this.listBoxRestaurant.Location = new System.Drawing.Point(21, 38);
            this.listBoxRestaurant.Name = "listBoxRestaurant";
            this.listBoxRestaurant.Size = new System.Drawing.Size(200, 355);
            this.listBoxRestaurant.TabIndex = 1;
            this.listBoxRestaurant.SelectedIndexChanged += new System.EventHandler(this.listBoxRestaurant_SelectedIndexChanged);
            // 
            // buttonRetour
            // 
            this.buttonRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetour.Location = new System.Drawing.Point(564, 355);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(213, 71);
            this.buttonRetour.TabIndex = 10;
            this.buttonRetour.Text = "Accueil";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Chiffre d\'affaire du jour";
            // 
            // labelChiffreDAffaire
            // 
            this.labelChiffreDAffaire.AutoSize = true;
            this.labelChiffreDAffaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChiffreDAffaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelChiffreDAffaire.Location = new System.Drawing.Point(466, 97);
            this.labelChiffreDAffaire.Name = "labelChiffreDAffaire";
            this.labelChiffreDAffaire.Size = new System.Drawing.Size(74, 37);
            this.labelChiffreDAffaire.TabIndex = 12;
            this.labelChiffreDAffaire.Text = "200";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(546, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "€";
            // 
            // DetailGroupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelChiffreDAffaire);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.listBoxRestaurant);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "DetailGroupe";
            this.Text = "DetailGroupe";
            this.Load += new System.EventHandler(this.DetailGroupe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBoxRestaurant;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelChiffreDAffaire;
        private System.Windows.Forms.Label label2;
    }
}