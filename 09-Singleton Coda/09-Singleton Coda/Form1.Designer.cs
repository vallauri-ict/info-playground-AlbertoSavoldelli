namespace _09_Singleton_Coda
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnStampa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "INSERISCI:";
            // 
            // txtLibro
            // 
            this.txtLibro.Location = new System.Drawing.Point(124, 29);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(100, 20);
            this.txtLibro.TabIndex = 2;
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(249, 29);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(182, 23);
            this.btnInserisci.TabIndex = 3;
            this.btnInserisci.Text = "INSERISCI IN CODA DI STAMPA";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // btnStampa
            // 
            this.btnStampa.Location = new System.Drawing.Point(93, 74);
            this.btnStampa.Name = "btnStampa";
            this.btnStampa.Size = new System.Drawing.Size(219, 59);
            this.btnStampa.TabIndex = 4;
            this.btnStampa.Text = "STAMPA PRIMO ELEMENTO IN CODA";
            this.btnStampa.UseVisualStyleBackColor = true;
            this.btnStampa.Click += new System.EventHandler(this.btnStampa_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(462, 185);
            this.Controls.Add(this.btnStampa);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.txtLibro);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnStampa;
    }
}

