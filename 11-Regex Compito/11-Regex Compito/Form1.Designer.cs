namespace _11_Regex_Compito
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
            this.txtTarga = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnControllaTarga = new System.Windows.Forms.Button();
            this.btnControllaPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTarga
            // 
            this.txtTarga.Location = new System.Drawing.Point(53, 45);
            this.txtTarga.Name = "txtTarga";
            this.txtTarga.Size = new System.Drawing.Size(129, 20);
            this.txtTarga.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(53, 165);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(129, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // btnControllaTarga
            // 
            this.btnControllaTarga.Location = new System.Drawing.Point(263, 45);
            this.btnControllaTarga.Name = "btnControllaTarga";
            this.btnControllaTarga.Size = new System.Drawing.Size(152, 20);
            this.btnControllaTarga.TabIndex = 5;
            this.btnControllaTarga.Text = "CONTROLLA TARGA";
            this.btnControllaTarga.UseVisualStyleBackColor = true;
            this.btnControllaTarga.Click += new System.EventHandler(this.btnControllaTarga_Click);
            // 
            // btnControllaPassword
            // 
            this.btnControllaPassword.Location = new System.Drawing.Point(263, 165);
            this.btnControllaPassword.Name = "btnControllaPassword";
            this.btnControllaPassword.Size = new System.Drawing.Size(152, 23);
            this.btnControllaPassword.TabIndex = 6;
            this.btnControllaPassword.Text = "CONTROLLA PASSWORD";
            this.btnControllaPassword.UseVisualStyleBackColor = true;
            this.btnControllaPassword.Click += new System.EventHandler(this.btnControllaPassword_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 243);
            this.Controls.Add(this.btnControllaPassword);
            this.Controls.Add(this.btnControllaTarga);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtTarga);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTarga;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnControllaTarga;
        private System.Windows.Forms.Button btnControllaPassword;
    }
}

