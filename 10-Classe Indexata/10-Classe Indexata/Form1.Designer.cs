namespace _10_Classe_Indexata
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
            this.txtElementi = new System.Windows.Forms.TextBox();
            this.btnCreaClasse = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtElementi
            // 
            this.txtElementi.Location = new System.Drawing.Point(88, 54);
            this.txtElementi.Margin = new System.Windows.Forms.Padding(2);
            this.txtElementi.Name = "txtElementi";
            this.txtElementi.Size = new System.Drawing.Size(95, 20);
            this.txtElementi.TabIndex = 2;
            // 
            // btnCreaClasse
            // 
            this.btnCreaClasse.Location = new System.Drawing.Point(85, 89);
            this.btnCreaClasse.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreaClasse.Name = "btnCreaClasse";
            this.btnCreaClasse.Size = new System.Drawing.Size(98, 19);
            this.btnCreaClasse.TabIndex = 3;
            this.btnCreaClasse.Text = "CREA CLASSE";
            this.btnCreaClasse.UseVisualStyleBackColor = true;
            this.btnCreaClasse.Click += new System.EventHandler(this.btnCreaClasse_Click);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(85, 124);
            this.btnVisualizza.Margin = new System.Windows.Forms.Padding(2);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(98, 19);
            this.btnVisualizza.TabIndex = 4;
            this.btnVisualizza.Text = "VISUALIZZA";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 196);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.btnCreaClasse);
            this.Controls.Add(this.txtElementi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtElementi;
        private System.Windows.Forms.Button btnCreaClasse;
        private System.Windows.Forms.Button btnVisualizza;
    }
}

