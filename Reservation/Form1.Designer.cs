namespace Reservation
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
            this.buttonModifierReservation = new System.Windows.Forms.Button();
            this.buttonNouvelleReservation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonModifierReservation
            // 
            this.buttonModifierReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifierReservation.Location = new System.Drawing.Point(410, 104);
            this.buttonModifierReservation.Name = "buttonModifierReservation";
            this.buttonModifierReservation.Size = new System.Drawing.Size(359, 242);
            this.buttonModifierReservation.TabIndex = 3;
            this.buttonModifierReservation.Text = "Modifier reservation";
            this.buttonModifierReservation.UseVisualStyleBackColor = true;
            this.buttonModifierReservation.Click += new System.EventHandler(this.buttonModifierReservation_Click);
            // 
            // buttonNouvelleReservation
            // 
            this.buttonNouvelleReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNouvelleReservation.Location = new System.Drawing.Point(32, 104);
            this.buttonNouvelleReservation.Name = "buttonNouvelleReservation";
            this.buttonNouvelleReservation.Size = new System.Drawing.Size(359, 242);
            this.buttonNouvelleReservation.TabIndex = 2;
            this.buttonNouvelleReservation.Text = "Nouvelle reservation";
            this.buttonNouvelleReservation.UseVisualStyleBackColor = true;
            this.buttonNouvelleReservation.Click += new System.EventHandler(this.buttonNouvelleReservation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonModifierReservation);
            this.Controls.Add(this.buttonNouvelleReservation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonModifierReservation;
        private System.Windows.Forms.Button buttonNouvelleReservation;
    }
}

