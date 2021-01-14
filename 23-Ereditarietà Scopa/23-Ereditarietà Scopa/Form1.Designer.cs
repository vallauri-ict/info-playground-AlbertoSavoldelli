namespace _23_Ereditarietà_Scopa
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
            this.btnGenera = new System.Windows.Forms.Button();
            this.btnMischia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenera
            // 
            this.btnGenera.Location = new System.Drawing.Point(76, 31);
            this.btnGenera.Name = "btnGenera";
            this.btnGenera.Size = new System.Drawing.Size(164, 43);
            this.btnGenera.TabIndex = 0;
            this.btnGenera.Text = "GENERA MAZZO";
            this.btnGenera.UseVisualStyleBackColor = true;
            this.btnGenera.Click += new System.EventHandler(this.btnGenera_Click);
            // 
            // btnMischia
            // 
            this.btnMischia.Location = new System.Drawing.Point(76, 113);
            this.btnMischia.Name = "btnMischia";
            this.btnMischia.Size = new System.Drawing.Size(164, 43);
            this.btnMischia.TabIndex = 1;
            this.btnMischia.Text = "MISCHIA MAZZO";
            this.btnMischia.UseVisualStyleBackColor = true;
            this.btnMischia.Click += new System.EventHandler(this.btnMischia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 242);
            this.Controls.Add(this.btnMischia);
            this.Controls.Add(this.btnGenera);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenera;
        private System.Windows.Forms.Button btnMischia;
    }
}

