namespace _15_Negozio_Dictionary
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
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblArt = new System.Windows.Forms.Label();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.btnRicerca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "KEY:";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(100, 35);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(100, 20);
            this.txtKey.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "VALUE:";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(100, 94);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 6;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(271, 38);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(124, 13);
            this.lblNum.TabIndex = 8;
            this.lblNum.Text = "NUMERO ELEMENTI: 0";
            // 
            // lblArt
            // 
            this.lblArt.AutoSize = true;
            this.lblArt.Location = new System.Drawing.Point(271, 101);
            this.lblArt.Name = "lblArt";
            this.lblArt.Size = new System.Drawing.Size(227, 13);
            this.lblArt.TabIndex = 9;
            this.lblArt.Text = "NOME ARTICOLO CERCATO: nessun articolo";
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(55, 189);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(83, 30);
            this.btnInserisci.TabIndex = 10;
            this.btnInserisci.Text = "INSERISCI";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(232, 189);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(83, 30);
            this.btnVisualizza.TabIndex = 11;
            this.btnVisualizza.Text = "VISUALIZZA";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // btnRicerca
            // 
            this.btnRicerca.Location = new System.Drawing.Point(391, 189);
            this.btnRicerca.Name = "btnRicerca";
            this.btnRicerca.Size = new System.Drawing.Size(83, 30);
            this.btnRicerca.TabIndex = 12;
            this.btnRicerca.Text = "RICERCA";
            this.btnRicerca.UseVisualStyleBackColor = true;
            this.btnRicerca.Click += new System.EventHandler(this.btnRicerca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRicerca);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.lblArt);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblArt;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Button btnRicerca;
    }
}

