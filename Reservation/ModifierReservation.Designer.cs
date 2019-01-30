namespace Reservation
{
    partial class ModifierReservation
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
            this.textBoxNumeroReservation = new System.Windows.Forms.TextBox();
            this.buttonContinuer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Entrez votre numero de reservation";
            // 
            // textBoxNumeroReservation
            // 
            this.textBoxNumeroReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroReservation.Location = new System.Drawing.Point(88, 88);
            this.textBoxNumeroReservation.Name = "textBoxNumeroReservation";
            this.textBoxNumeroReservation.Size = new System.Drawing.Size(202, 49);
            this.textBoxNumeroReservation.TabIndex = 4;
            // 
            // buttonContinuer
            // 
            this.buttonContinuer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinuer.Location = new System.Drawing.Point(88, 221);
            this.buttonContinuer.Name = "buttonContinuer";
            this.buttonContinuer.Size = new System.Drawing.Size(214, 62);
            this.buttonContinuer.TabIndex = 3;
            this.buttonContinuer.Text = "Continuer";
            this.buttonContinuer.UseVisualStyleBackColor = true;
            this.buttonContinuer.Click += new System.EventHandler(this.buttonContinuer_Click);
            // 
            // ModifierReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 303);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumeroReservation);
            this.Controls.Add(this.buttonContinuer);
            this.Name = "ModifierReservation";
            this.Text = "ModifierReservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumeroReservation;
        private System.Windows.Forms.Button buttonContinuer;
    }
}