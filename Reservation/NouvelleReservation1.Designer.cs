namespace Reservation
{
    partial class NouvelleReservation1
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.dateTimePickerReservation = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quand voulez-vous reserver?";
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuivant.Location = new System.Drawing.Point(95, 158);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(143, 47);
            this.buttonSuivant.TabIndex = 7;
            this.buttonSuivant.Text = "Suivant";
            this.buttonSuivant.UseVisualStyleBackColor = true;
            this.buttonSuivant.Click += new System.EventHandler(this.buttonSuivant_Click);
            // 
            // dateTimePickerReservation
            // 
            this.dateTimePickerReservation.Location = new System.Drawing.Point(56, 85);
            this.dateTimePickerReservation.Name = "dateTimePickerReservation";
            this.dateTimePickerReservation.Size = new System.Drawing.Size(235, 20);
            this.dateTimePickerReservation.TabIndex = 6;
            // 
            // NouvelleReservation1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 242);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSuivant);
            this.Controls.Add(this.dateTimePickerReservation);
            this.Name = "NouvelleReservation1";
            this.Text = "NouvelleReservation1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.DateTimePicker dateTimePickerReservation;
    }
}