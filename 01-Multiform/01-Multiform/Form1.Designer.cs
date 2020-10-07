namespace _01_Multiform
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
            this.BtnApriForm2 = new System.Windows.Forms.Button();
            this.BtnForm2 = new System.Windows.Forms.Button();
            this.txtPassata = new System.Windows.Forms.TextBox();
            this.btnPassaTxt = new System.Windows.Forms.Button();
            this.btnFormModale = new System.Windows.Forms.Button();
            this.lblNomefm = new System.Windows.Forms.Label();
            this.txtNomefm = new System.Windows.Forms.TextBox();
            this.lblEtafm = new System.Windows.Forms.Label();
            this.txtEtafm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnApriForm2
            // 
            this.BtnApriForm2.Location = new System.Drawing.Point(49, 61);
            this.BtnApriForm2.Name = "BtnApriForm2";
            this.BtnApriForm2.Size = new System.Drawing.Size(102, 23);
            this.BtnApriForm2.TabIndex = 0;
            this.BtnApriForm2.Text = "APRI FORM 2";
            this.BtnApriForm2.UseVisualStyleBackColor = true;
            this.BtnApriForm2.Click += new System.EventHandler(this.BtnApriForm2_Click);
            // 
            // BtnForm2
            // 
            this.BtnForm2.Location = new System.Drawing.Point(206, 61);
            this.BtnForm2.Name = "BtnForm2";
            this.BtnForm2.Size = new System.Drawing.Size(75, 23);
            this.BtnForm2.TabIndex = 1;
            this.BtnForm2.Text = "FORM 2";
            this.BtnForm2.UseVisualStyleBackColor = true;
            this.BtnForm2.Click += new System.EventHandler(this.BtnForm2_Click);
            // 
            // txtPassata
            // 
            this.txtPassata.Location = new System.Drawing.Point(49, 116);
            this.txtPassata.Name = "txtPassata";
            this.txtPassata.Size = new System.Drawing.Size(100, 20);
            this.txtPassata.TabIndex = 2;
            // 
            // btnPassaTxt
            // 
            this.btnPassaTxt.Location = new System.Drawing.Point(188, 113);
            this.btnPassaTxt.Name = "btnPassaTxt";
            this.btnPassaTxt.Size = new System.Drawing.Size(93, 23);
            this.btnPassaTxt.TabIndex = 3;
            this.btnPassaTxt.Text = "Passa i txt a F2";
            this.btnPassaTxt.UseVisualStyleBackColor = true;
            this.btnPassaTxt.Click += new System.EventHandler(this.btnPassaTxt_Click);
            // 
            // btnFormModale
            // 
            this.btnFormModale.Location = new System.Drawing.Point(49, 202);
            this.btnFormModale.Name = "btnFormModale";
            this.btnFormModale.Size = new System.Drawing.Size(130, 23);
            this.btnFormModale.TabIndex = 4;
            this.btnFormModale.Text = "APRI FORM MODALE";
            this.btnFormModale.UseVisualStyleBackColor = true;
            this.btnFormModale.Click += new System.EventHandler(this.btnFormModale_Click);
            // 
            // lblNomefm
            // 
            this.lblNomefm.AutoSize = true;
            this.lblNomefm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.35F);
            this.lblNomefm.Location = new System.Drawing.Point(46, 158);
            this.lblNomefm.Name = "lblNomefm";
            this.lblNomefm.Size = new System.Drawing.Size(44, 15);
            this.lblNomefm.TabIndex = 5;
            this.lblNomefm.Text = "NOME";
            // 
            // txtNomefm
            // 
            this.txtNomefm.Location = new System.Drawing.Point(110, 158);
            this.txtNomefm.Name = "txtNomefm";
            this.txtNomefm.ReadOnly = true;
            this.txtNomefm.Size = new System.Drawing.Size(100, 20);
            this.txtNomefm.TabIndex = 6;
            // 
            // lblEtafm
            // 
            this.lblEtafm.AutoSize = true;
            this.lblEtafm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.35F);
            this.lblEtafm.Location = new System.Drawing.Point(252, 161);
            this.lblEtafm.Name = "lblEtafm";
            this.lblEtafm.Size = new System.Drawing.Size(29, 15);
            this.lblEtafm.TabIndex = 7;
            this.lblEtafm.Text = "ETA";
            // 
            // txtEtafm
            // 
            this.txtEtafm.Location = new System.Drawing.Point(319, 156);
            this.txtEtafm.Name = "txtEtafm";
            this.txtEtafm.ReadOnly = true;
            this.txtEtafm.Size = new System.Drawing.Size(100, 20);
            this.txtEtafm.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEtafm);
            this.Controls.Add(this.lblEtafm);
            this.Controls.Add(this.txtNomefm);
            this.Controls.Add(this.lblNomefm);
            this.Controls.Add(this.btnFormModale);
            this.Controls.Add(this.btnPassaTxt);
            this.Controls.Add(this.txtPassata);
            this.Controls.Add(this.BtnForm2);
            this.Controls.Add(this.BtnApriForm2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnApriForm2;
        private System.Windows.Forms.Button BtnForm2;
        private System.Windows.Forms.TextBox txtPassata;
        private System.Windows.Forms.Button btnPassaTxt;
        private System.Windows.Forms.Button btnFormModale;
        private System.Windows.Forms.Label lblNomefm;
        private System.Windows.Forms.TextBox txtNomefm;
        private System.Windows.Forms.Label lblEtafm;
        private System.Windows.Forms.TextBox txtEtafm;
    }
}

