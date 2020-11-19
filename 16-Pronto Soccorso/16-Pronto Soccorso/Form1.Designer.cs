namespace _16_Pronto_Soccorso
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
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVisita = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEta = new System.Windows.Forms.TextBox();
            this.txtColore = new System.Windows.Forms.TextBox();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.btnRegistra = new System.Windows.Forms.Button();
            this.bntAddTemp = new System.Windows.Forms.Button();
            this.lblInfoPaziente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTRAZIONE PAZIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ETA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "COLORE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 184);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "TEMPERATURA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "MEDICO LIBERO";
            // 
            // btnVisita
            // 
            this.btnVisita.Location = new System.Drawing.Point(370, 58);
            this.btnVisita.Margin = new System.Windows.Forms.Padding(2);
            this.btnVisita.Name = "btnVisita";
            this.btnVisita.Size = new System.Drawing.Size(113, 26);
            this.btnVisita.TabIndex = 19;
            this.btnVisita.Text = "VISITA PAZIENTE";
            this.btnVisita.UseVisualStyleBackColor = true;
            this.btnVisita.Click += new System.EventHandler(this.btnVisita_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(206, 62);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(69, 20);
            this.txtNome.TabIndex = 20;
            // 
            // txtEta
            // 
            this.txtEta.Location = new System.Drawing.Point(206, 105);
            this.txtEta.Margin = new System.Windows.Forms.Padding(2);
            this.txtEta.Name = "txtEta";
            this.txtEta.Size = new System.Drawing.Size(69, 20);
            this.txtEta.TabIndex = 21;
            // 
            // txtColore
            // 
            this.txtColore.Location = new System.Drawing.Point(206, 141);
            this.txtColore.Margin = new System.Windows.Forms.Padding(2);
            this.txtColore.Name = "txtColore";
            this.txtColore.Size = new System.Drawing.Size(69, 20);
            this.txtColore.TabIndex = 22;
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(206, 181);
            this.txtTemperatura.Margin = new System.Windows.Forms.Padding(2);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(69, 20);
            this.txtTemperatura.TabIndex = 23;
            // 
            // btnRegistra
            // 
            this.btnRegistra.Location = new System.Drawing.Point(84, 218);
            this.btnRegistra.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistra.Name = "btnRegistra";
            this.btnRegistra.Size = new System.Drawing.Size(138, 26);
            this.btnRegistra.TabIndex = 24;
            this.btnRegistra.Text = "REGISTRA";
            this.btnRegistra.UseVisualStyleBackColor = true;
            this.btnRegistra.Click += new System.EventHandler(this.btnRegistra_Click);
            // 
            // bntAddTemp
            // 
            this.bntAddTemp.Location = new System.Drawing.Point(272, 218);
            this.bntAddTemp.Margin = new System.Windows.Forms.Padding(2);
            this.bntAddTemp.Name = "bntAddTemp";
            this.bntAddTemp.Size = new System.Drawing.Size(173, 26);
            this.bntAddTemp.TabIndex = 25;
            this.bntAddTemp.Text = "VISUALIZZA TEMPERATURE";
            this.bntAddTemp.UseVisualStyleBackColor = true;
            this.bntAddTemp.Click += new System.EventHandler(this.bntAddTemp_Click);
            // 
            // lblInfoPaziente
            // 
            this.lblInfoPaziente.AutoSize = true;
            this.lblInfoPaziente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoPaziente.Location = new System.Drawing.Point(367, 108);
            this.lblInfoPaziente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfoPaziente.Name = "lblInfoPaziente";
            this.lblInfoPaziente.Size = new System.Drawing.Size(115, 17);
            this.lblInfoPaziente.TabIndex = 26;
            this.lblInfoPaziente.Text = "INFO PAZIENTE:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfoPaziente);
            this.Controls.Add(this.bntAddTemp);
            this.Controls.Add(this.btnRegistra);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.txtColore);
            this.Controls.Add(this.txtEta);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnVisita);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVisita;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEta;
        private System.Windows.Forms.TextBox txtColore;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Button btnRegistra;
        private System.Windows.Forms.Button bntAddTemp;
        private System.Windows.Forms.Label lblInfoPaziente;
    }
}

