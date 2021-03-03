namespace _30_Interfaccia_Icomparer
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOrdinaCognome = new System.Windows.Forms.Button();
            this.btnOrdinaNome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrdinaCognome
            // 
            this.btnOrdinaCognome.Location = new System.Drawing.Point(67, 12);
            this.btnOrdinaCognome.Name = "btnOrdinaCognome";
            this.btnOrdinaCognome.Size = new System.Drawing.Size(212, 65);
            this.btnOrdinaCognome.TabIndex = 0;
            this.btnOrdinaCognome.Text = "ORDINA PER COGNOME";
            this.btnOrdinaCognome.UseVisualStyleBackColor = true;
            this.btnOrdinaCognome.Click += new System.EventHandler(this.btnOrdinaCognome_Click);
            // 
            // btnOrdinaNome
            // 
            this.btnOrdinaNome.Location = new System.Drawing.Point(67, 83);
            this.btnOrdinaNome.Name = "btnOrdinaNome";
            this.btnOrdinaNome.Size = new System.Drawing.Size(212, 65);
            this.btnOrdinaNome.TabIndex = 1;
            this.btnOrdinaNome.Text = "ORDINA PER NOME";
            this.btnOrdinaNome.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 167);
            this.Controls.Add(this.btnOrdinaNome);
            this.Controls.Add(this.btnOrdinaCognome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrdinaCognome;
        private System.Windows.Forms.Button btnOrdinaNome;
    }
}

