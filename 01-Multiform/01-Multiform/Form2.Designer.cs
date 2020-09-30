namespace _01_Multiform
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLeggiValore = new System.Windows.Forms.Button();
            this.txtForm2 = new System.Windows.Forms.TextBox();
            this.btnValoreTxt = new System.Windows.Forms.Button();
            this.btnApriFormFiglia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeggiValore
            // 
            this.btnLeggiValore.Location = new System.Drawing.Point(36, 26);
            this.btnLeggiValore.Name = "btnLeggiValore";
            this.btnLeggiValore.Size = new System.Drawing.Size(75, 23);
            this.btnLeggiValore.TabIndex = 0;
            this.btnLeggiValore.Text = "Leggi valore";
            this.btnLeggiValore.UseVisualStyleBackColor = true;
            this.btnLeggiValore.Click += new System.EventHandler(this.btnLeggiValore_Click);
            // 
            // txtForm2
            // 
            this.txtForm2.Location = new System.Drawing.Point(36, 55);
            this.txtForm2.Name = "txtForm2";
            this.txtForm2.Size = new System.Drawing.Size(100, 20);
            this.txtForm2.TabIndex = 1;
            // 
            // btnValoreTxt
            // 
            this.btnValoreTxt.Location = new System.Drawing.Point(142, 55);
            this.btnValoreTxt.Name = "btnValoreTxt";
            this.btnValoreTxt.Size = new System.Drawing.Size(75, 23);
            this.btnValoreTxt.TabIndex = 2;
            this.btnValoreTxt.Text = "Leggi valore";
            this.btnValoreTxt.UseVisualStyleBackColor = true;
            this.btnValoreTxt.Click += new System.EventHandler(this.btnValoreTxt_Click);
            // 
            // btnApriFormFiglia
            // 
            this.btnApriFormFiglia.Location = new System.Drawing.Point(86, 102);
            this.btnApriFormFiglia.Name = "btnApriFormFiglia";
            this.btnApriFormFiglia.Size = new System.Drawing.Size(102, 23);
            this.btnApriFormFiglia.TabIndex = 3;
            this.btnApriFormFiglia.Text = "Apri form figlia";
            this.btnApriFormFiglia.UseVisualStyleBackColor = true;
            this.btnApriFormFiglia.Click += new System.EventHandler(this.btnApriFormFiglia_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 210);
            this.Controls.Add(this.btnApriFormFiglia);
            this.Controls.Add(this.btnValoreTxt);
            this.Controls.Add(this.txtForm2);
            this.Controls.Add(this.btnLeggiValore);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeggiValore;
        private System.Windows.Forms.TextBox txtForm2;
        private System.Windows.Forms.Button btnValoreTxt;
        private System.Windows.Forms.Button btnApriFormFiglia;
    }
}