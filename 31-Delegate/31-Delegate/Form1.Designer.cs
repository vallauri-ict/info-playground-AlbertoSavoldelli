namespace _31_Delegate
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
            this.btnpiu = new System.Windows.Forms.Button();
            this.btnPer = new System.Windows.Forms.Button();
            this.btnMeno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnpiu
            // 
            this.btnpiu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpiu.Location = new System.Drawing.Point(12, 10);
            this.btnpiu.Name = "btnpiu";
            this.btnpiu.Size = new System.Drawing.Size(85, 94);
            this.btnpiu.TabIndex = 0;
            this.btnpiu.Text = "+";
            this.btnpiu.UseVisualStyleBackColor = true;
            this.btnpiu.Click += new System.EventHandler(this.btnpiu_Click);
            // 
            // btnPer
            // 
            this.btnPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPer.Location = new System.Drawing.Point(124, 10);
            this.btnPer.Name = "btnPer";
            this.btnPer.Size = new System.Drawing.Size(85, 94);
            this.btnPer.TabIndex = 1;
            this.btnPer.Text = "*";
            this.btnPer.UseVisualStyleBackColor = true;
            this.btnPer.Click += new System.EventHandler(this.btnPer_Click);
            // 
            // btnMeno
            // 
            this.btnMeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeno.Location = new System.Drawing.Point(242, 10);
            this.btnMeno.Name = "btnMeno";
            this.btnMeno.Size = new System.Drawing.Size(85, 94);
            this.btnMeno.TabIndex = 2;
            this.btnMeno.Text = "-";
            this.btnMeno.UseVisualStyleBackColor = true;
            this.btnMeno.Click += new System.EventHandler(this.btnMeno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 116);
            this.Controls.Add(this.btnMeno);
            this.Controls.Add(this.btnPer);
            this.Controls.Add(this.btnpiu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpiu;
        private System.Windows.Forms.Button btnPer;
        private System.Windows.Forms.Button btnMeno;
    }
}

