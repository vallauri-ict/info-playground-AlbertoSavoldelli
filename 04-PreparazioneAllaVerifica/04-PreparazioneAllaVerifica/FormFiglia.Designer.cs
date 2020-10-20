namespace _04_PreparazioneAllaVerifica
{
    partial class FormFiglia
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
            this.lblStringa = new System.Windows.Forms.Label();
            this.txtStringaFiglia = new System.Windows.Forms.TextBox();
            this.btnInvia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStringa
            // 
            this.lblStringa.AutoSize = true;
            this.lblStringa.Location = new System.Drawing.Point(67, 9);
            this.lblStringa.Name = "lblStringa";
            this.lblStringa.Size = new System.Drawing.Size(55, 13);
            this.lblStringa.TabIndex = 3;
            this.lblStringa.Text = "STRINGA";
            // 
            // txtStringaFiglia
            // 
            this.txtStringaFiglia.Location = new System.Drawing.Point(47, 36);
            this.txtStringaFiglia.Name = "txtStringaFiglia";
            this.txtStringaFiglia.Size = new System.Drawing.Size(100, 20);
            this.txtStringaFiglia.TabIndex = 6;
            // 
            // btnInvia
            // 
            this.btnInvia.Location = new System.Drawing.Point(60, 74);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(75, 23);
            this.btnInvia.TabIndex = 8;
            this.btnInvia.Text = "Invia";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // FormFiglia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 109);
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.txtStringaFiglia);
            this.Controls.Add(this.lblStringa);
            this.Name = "FormFiglia";
            this.Text = "FormFiglia";
            this.Load += new System.EventHandler(this.FormFiglia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStringa;
        private System.Windows.Forms.TextBox txtStringaFiglia;
        private System.Windows.Forms.Button btnInvia;
    }
}