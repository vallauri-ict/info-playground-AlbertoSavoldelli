namespace _07_Metodo_Factory
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
            this.lblLatoQuadrato = new System.Windows.Forms.Label();
            this.txtLatoQuadrato = new System.Windows.Forms.TextBox();
            this.btnCreaQuadrato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLatoQuadrato
            // 
            this.lblLatoQuadrato.AutoSize = true;
            this.lblLatoQuadrato.Location = new System.Drawing.Point(26, 9);
            this.lblLatoQuadrato.Name = "lblLatoQuadrato";
            this.lblLatoQuadrato.Size = new System.Drawing.Size(179, 13);
            this.lblLatoQuadrato.TabIndex = 1;
            this.lblLatoQuadrato.Text = "INSERISCI LA MISURA DEL LATO:";
            // 
            // txtLatoQuadrato
            // 
            this.txtLatoQuadrato.Location = new System.Drawing.Point(224, 6);
            this.txtLatoQuadrato.Name = "txtLatoQuadrato";
            this.txtLatoQuadrato.Size = new System.Drawing.Size(136, 20);
            this.txtLatoQuadrato.TabIndex = 2;
            // 
            // btnCreaQuadrato
            // 
            this.btnCreaQuadrato.Location = new System.Drawing.Point(109, 54);
            this.btnCreaQuadrato.Name = "btnCreaQuadrato";
            this.btnCreaQuadrato.Size = new System.Drawing.Size(135, 23);
            this.btnCreaQuadrato.TabIndex = 3;
            this.btnCreaQuadrato.Text = "CREA";
            this.btnCreaQuadrato.UseVisualStyleBackColor = true;
            this.btnCreaQuadrato.Click += new System.EventHandler(this.btnCreaQuadrato_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 122);
            this.Controls.Add(this.btnCreaQuadrato);
            this.Controls.Add(this.txtLatoQuadrato);
            this.Controls.Add(this.lblLatoQuadrato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLatoQuadrato;
        private System.Windows.Forms.TextBox txtLatoQuadrato;
        private System.Windows.Forms.Button btnCreaQuadrato;
    }
}

