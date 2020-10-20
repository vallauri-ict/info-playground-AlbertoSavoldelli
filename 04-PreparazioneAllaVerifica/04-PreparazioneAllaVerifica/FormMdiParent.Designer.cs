namespace _04_PreparazioneAllaVerifica
{
    partial class FormMdiParent
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
            this.btnFormMdiChildren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormMdiChildren
            // 
            this.btnFormMdiChildren.Location = new System.Drawing.Point(283, 93);
            this.btnFormMdiChildren.Name = "btnFormMdiChildren";
            this.btnFormMdiChildren.Size = new System.Drawing.Size(182, 86);
            this.btnFormMdiChildren.TabIndex = 1;
            this.btnFormMdiChildren.Text = "CREA FORM MDI CHILDREN";
            this.btnFormMdiChildren.UseVisualStyleBackColor = true;
            this.btnFormMdiChildren.Click += new System.EventHandler(this.btnFormMdiChildren_Click);
            // 
            // FormMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFormMdiChildren);
            this.IsMdiContainer = true;
            this.Name = "FormMdi";
            this.Text = "FormMdi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormMdiChildren;
    }
}