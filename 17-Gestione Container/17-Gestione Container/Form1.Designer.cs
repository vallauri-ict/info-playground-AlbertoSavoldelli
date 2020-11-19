namespace _17_Gestione_Container
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtTara = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CODICE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PESO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "TARA:";
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(63, 155);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(135, 36);
            this.btnInserisci.TabIndex = 7;
            this.btnInserisci.Text = "INSERISCI CONATINER";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(235, 155);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(136, 36);
            this.btnElimina.TabIndex = 8;
            this.btnElimina.Text = "ELIMINA CONTAINER";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(159, 32);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(100, 20);
            this.txtCodice.TabIndex = 9;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(159, 77);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 10;
            // 
            // txtTara
            // 
            this.txtTara.Location = new System.Drawing.Point(159, 118);
            this.txtTara.Name = "txtTara";
            this.txtTara.Size = new System.Drawing.Size(100, 20);
            this.txtTara.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 229);
            this.Controls.Add(this.txtTara);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtCodice);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.TextBox txtCodice;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtTara;
    }
}

