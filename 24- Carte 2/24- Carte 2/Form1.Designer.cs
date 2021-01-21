namespace _24__Carte_2
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
            this.txtValore = new System.Windows.Forms.TextBox();
            this.txtSeme = new System.Windows.Forms.TextBox();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnDammi = new System.Windows.Forms.Button();
            this.btnCerca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "VALORE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "SEME:";
            // 
            // txtValore
            // 
            this.txtValore.Location = new System.Drawing.Point(154, 39);
            this.txtValore.Name = "txtValore";
            this.txtValore.Size = new System.Drawing.Size(100, 20);
            this.txtValore.TabIndex = 6;
            // 
            // txtSeme
            // 
            this.txtSeme.Location = new System.Drawing.Point(154, 92);
            this.txtSeme.Name = "txtSeme";
            this.txtSeme.Size = new System.Drawing.Size(100, 20);
            this.txtSeme.TabIndex = 7;
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(317, 39);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(115, 35);
            this.btnInserisci.TabIndex = 8;
            this.btnInserisci.Text = "INSERISCI";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // btnDammi
            // 
            this.btnDammi.Location = new System.Drawing.Point(492, 39);
            this.btnDammi.Name = "btnDammi";
            this.btnDammi.Size = new System.Drawing.Size(115, 35);
            this.btnDammi.TabIndex = 9;
            this.btnDammi.Text = "DAMMI";
            this.btnDammi.UseVisualStyleBackColor = true;
            this.btnDammi.Click += new System.EventHandler(this.btnDammi_Click);
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(403, 84);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(115, 35);
            this.btnCerca.TabIndex = 10;
            this.btnCerca.Text = "CERCA";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.btnDammi);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.txtSeme);
            this.Controls.Add(this.txtValore);
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
        private System.Windows.Forms.TextBox txtValore;
        private System.Windows.Forms.TextBox txtSeme;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnDammi;
        private System.Windows.Forms.Button btnCerca;
    }
}

