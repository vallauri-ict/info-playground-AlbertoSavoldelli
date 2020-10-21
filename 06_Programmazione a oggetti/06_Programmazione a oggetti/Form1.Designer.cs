namespace _06_Programmazione_a_oggetti
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
            this.lblBase = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lblAltezza = new System.Windows.Forms.Label();
            this.txtAltezza = new System.Windows.Forms.TextBox();
            this.btnCrea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(12, 64);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(35, 13);
            this.lblBase.TabIndex = 0;
            this.lblBase.Text = "BASE";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(85, 64);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 1;
            // 
            // lblAltezza
            // 
            this.lblAltezza.AutoSize = true;
            this.lblAltezza.Location = new System.Drawing.Point(12, 107);
            this.lblAltezza.Name = "lblAltezza";
            this.lblAltezza.Size = new System.Drawing.Size(55, 13);
            this.lblAltezza.TabIndex = 2;
            this.lblAltezza.Text = "ALTEZZA";
            // 
            // txtAltezza
            // 
            this.txtAltezza.Location = new System.Drawing.Point(85, 104);
            this.txtAltezza.Name = "txtAltezza";
            this.txtAltezza.Size = new System.Drawing.Size(100, 20);
            this.txtAltezza.TabIndex = 3;
            // 
            // btnCrea
            // 
            this.btnCrea.Location = new System.Drawing.Point(78, 163);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Size = new System.Drawing.Size(75, 23);
            this.btnCrea.TabIndex = 4;
            this.btnCrea.Text = "CREA";
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Click += new System.EventHandler(this.btnCrea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 215);
            this.Controls.Add(this.btnCrea);
            this.Controls.Add(this.txtAltezza);
            this.Controls.Add(this.lblAltezza);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.lblBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label lblAltezza;
        private System.Windows.Forms.TextBox txtAltezza;
        private System.Windows.Forms.Button btnCrea;
    }
}

