namespace Administration
{
    partial class Form1
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
            this.buttonCarte = new System.Windows.Forms.Button();
            this.listBoxRestaurant = new System.Windows.Forms.ListBox();
            this.listBoxGroupe = new System.Windows.Forms.ListBox();
            this.buttonDetailResto = new System.Windows.Forms.Button();
            this.buttonDetailGroupe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCarte
            // 
            this.buttonCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCarte.Location = new System.Drawing.Point(433, 29);
            this.buttonCarte.Name = "buttonCarte";
            this.buttonCarte.Size = new System.Drawing.Size(157, 56);
            this.buttonCarte.TabIndex = 5;
            this.buttonCarte.Text = "Gestion Carte";
            this.buttonCarte.UseVisualStyleBackColor = true;
            this.buttonCarte.Click += new System.EventHandler(this.buttonCarte_Click);
            // 
            // listBoxRestaurant
            // 
            this.listBoxRestaurant.FormattingEnabled = true;
            this.listBoxRestaurant.Location = new System.Drawing.Point(190, 29);
            this.listBoxRestaurant.MultiColumn = true;
            this.listBoxRestaurant.Name = "listBoxRestaurant";
            this.listBoxRestaurant.Size = new System.Drawing.Size(169, 160);
            this.listBoxRestaurant.TabIndex = 4;
            // 
            // listBoxGroupe
            // 
            this.listBoxGroupe.FormattingEnabled = true;
            this.listBoxGroupe.Location = new System.Drawing.Point(15, 29);
            this.listBoxGroupe.Name = "listBoxGroupe";
            this.listBoxGroupe.Size = new System.Drawing.Size(169, 56);
            this.listBoxGroupe.TabIndex = 3;
            this.listBoxGroupe.SelectedIndexChanged += new System.EventHandler(this.listBoxGroupe_SelectedIndexChanged);
            // 
            // buttonDetailResto
            // 
            this.buttonDetailResto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetailResto.Location = new System.Drawing.Point(433, 102);
            this.buttonDetailResto.Name = "buttonDetailResto";
            this.buttonDetailResto.Size = new System.Drawing.Size(157, 56);
            this.buttonDetailResto.TabIndex = 6;
            this.buttonDetailResto.Text = "Detail resto";
            this.buttonDetailResto.UseVisualStyleBackColor = true;
            this.buttonDetailResto.Click += new System.EventHandler(this.buttonDetailResto_Click);
            // 
            // buttonDetailGroupe
            // 
            this.buttonDetailGroupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetailGroupe.Location = new System.Drawing.Point(15, 133);
            this.buttonDetailGroupe.Name = "buttonDetailGroupe";
            this.buttonDetailGroupe.Size = new System.Drawing.Size(157, 56);
            this.buttonDetailGroupe.TabIndex = 7;
            this.buttonDetailGroupe.Text = "Detail groupe";
            this.buttonDetailGroupe.UseVisualStyleBackColor = true;
            this.buttonDetailGroupe.Click += new System.EventHandler(this.buttonDetailGroupe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 204);
            this.Controls.Add(this.buttonDetailGroupe);
            this.Controls.Add(this.buttonDetailResto);
            this.Controls.Add(this.buttonCarte);
            this.Controls.Add(this.listBoxRestaurant);
            this.Controls.Add(this.listBoxGroupe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCarte;
        private System.Windows.Forms.ListBox listBoxRestaurant;
        private System.Windows.Forms.ListBox listBoxGroupe;
        private System.Windows.Forms.Button buttonDetailResto;
        private System.Windows.Forms.Button buttonDetailGroupe;
    }
}