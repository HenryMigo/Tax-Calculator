namespace Tax_Calculator
{
    partial class Form1
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
            this.bttnConfirm = new System.Windows.Forms.Button();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnConfirm
            // 
            this.bttnConfirm.Location = new System.Drawing.Point(62, 55);
            this.bttnConfirm.Name = "bttnConfirm";
            this.bttnConfirm.Size = new System.Drawing.Size(100, 23);
            this.bttnConfirm.TabIndex = 0;
            this.bttnConfirm.Text = "Confirm";
            this.bttnConfirm.UseVisualStyleBackColor = true;
            this.bttnConfirm.Click += new System.EventHandler(this.bttnConfirm_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(62, 29);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(100, 20);
            this.txtBox1.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(62, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 90);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.bttnConfirm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnConfirm;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Label lblTitle;
    }
}

